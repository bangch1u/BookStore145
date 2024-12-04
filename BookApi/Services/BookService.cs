using BookData.Data.Entities;
using BookData.DataTransferObjects;
using BookData.Repositories;
using BookData.Repositories.CommonRepos;
using BookData.ViewModels;
using System.Net;

namespace BookApi.Services
{
    public class BookService : IBookService
    {
        private readonly IGenericRepository<Book> _bookCUDRepos;
        private readonly IBookRepos _bookReadRepos;
        private readonly IAuthorRepos _authorRepos;
        private readonly IGenreRepos _genreRepos;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public BookService(IGenericRepository<Book> bookCUDRepos,
            IBookRepos bookReadRepos,
            IAuthorRepos authorRepos,
            IGenreRepos genreRepos,
            IWebHostEnvironment webHostEnvironment)
        {
            _bookCUDRepos = bookCUDRepos;
            _bookReadRepos = bookReadRepos;
            _authorRepos = authorRepos;
            _genreRepos = genreRepos;   
            _webHostEnvironment = webHostEnvironment;
        }
        public static int PAGE_SIZE { get; set; } = 4;
        public bool createBook(BookDto book)
        {
            var bookNew = new Book()
            {
                BookId = Guid.NewGuid(),
                BookTitle = book.BookName,
                Price = book.BookPrices,
                CoverImage = book.urlImg,
                PublicationYear = book.PublicationYear,
                StockQuantity = book.Stock,
            };

            bookNew.Authors = new List<Author>();
            bookNew.Genres = new List<Genre>();
            foreach (Guid idAuthor in book.AuthorIds)
            {
                var author = _authorRepos.getById(idAuthor);
                if (author != null)
                {
                    bookNew.Authors.Add(author);
                }
            }
            foreach (Guid idGenre in book.GenreIds)
            {
                var genre = _genreRepos.GetById(idGenre);
                if (genre != null)
                {
                    bookNew.Genres.Add(genre);
                }
            }
            _bookCUDRepos.Insert(bookNew);
            return _bookCUDRepos.Save();
        }

        public bool deleteBook(Guid id)
        {
            var book = _bookReadRepos.getById(id);
            if (book != null)
            {
                if(book.CoverImage != null)
                {
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", book.CoverImage);
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
               
                _bookCUDRepos.Delete(book);
                _bookCUDRepos.Save();
                return true;
            }
            return false;
        }

        public List<Book> getAll()
        {
            return _bookReadRepos.getAll();
        }

        public List<Book> getAllPagedList(int page = 1)
        {
            var allBook = _bookReadRepos.getAll();
           
            var result = PaginatedList<Book>.Create(allBook, page, PAGE_SIZE);
            return result;
        }

        public Book getById(Guid id)
        {
            return _bookReadRepos.getById(id);
        }

        public bool updateBook(Guid id, BookDto book )
        {
            string trustedFileNameForFileStorage = null;
            if (book.ImgFile != null &&  book.ImgFile.Length > 0)
            {
                var unstrestedFileName = book.ImgFile.FileName;
                var trustedFileNameForDisplay  = WebUtility.HtmlEncode(unstrestedFileName);
                trustedFileNameForFileStorage = Path.GetRandomFileName();
                var fileExtension = Path.GetExtension(unstrestedFileName);
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads");
                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                string newFilePath = Path.Combine(uploadsFolder, trustedFileNameForFileStorage);
                using(FileStream fs = new(newFilePath, FileMode.Create))
                {
                    book.ImgFile.CopyTo(fs);
                }
            }


            var bookNow = _bookReadRepos.getById(id);
            if (bookNow != null)
            {
                if (bookNow.CoverImage != null)
                {
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", bookNow.CoverImage);
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
                bookNow.BookTitle = book.BookName;
                bookNow.Price = book.BookPrices;
                bookNow.CoverImage = !string.IsNullOrEmpty(trustedFileNameForFileStorage) ? trustedFileNameForFileStorage : null ;
                bookNow.StockQuantity = book.Stock;
                List<Author> listAuthor = new List<Author>();
                if(book.AuthorIds != null)
                {

                    foreach (Guid idAuthor in book.AuthorIds)
                    {
                        var author = _authorRepos.getById(idAuthor);
                        if (author != null)
                        {
                            listAuthor.Add(author);
                        }
                    }
                }
               
                List<Genre> listGenre = new List<Genre>();
                if( book.GenreIds != null)
                {
                    foreach (Guid idGenre in book.GenreIds)
                    {
                        var genre = _genreRepos.GetById(idGenre);
                        if (genre != null)
                        {
                            listGenre.Add(genre);
                        }
                    }
                }
                bookNow.Genres = listGenre;
                bookNow.Authors = listAuthor;

                _bookCUDRepos.Update(bookNow);
                _bookCUDRepos.Save();
                return true;
            }
            return false;
        }
    }
}
