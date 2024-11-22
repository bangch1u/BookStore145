using BookData.Data.Entities;
using BookData.DataTransferObjects;
using BookData.Repositories;
using BookData.Repositories.CommonRepos;

namespace BookApi.Services
{
    public class BookService : IBookService
    {
        private readonly IGenericRepository<Book> _bookCUDRepos;
        private readonly IBookRepos _bookReadRepos;
        private readonly IAuthorRepos _authorRepos;
        private readonly IGenreRepos _genreRepos;
        public BookService(IGenericRepository<Book> bookCUDRepos,
            IBookRepos bookReadRepos,
            IAuthorRepos authorRepos,
            IGenreRepos genreRepos)
        {
            _bookCUDRepos = bookCUDRepos;
            _bookReadRepos = bookReadRepos;
            _authorRepos = authorRepos;
            _genreRepos = genreRepos;   
        }

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

        public Book getById(Guid id)
        {
            return _bookReadRepos.getById(id);
        }

        public bool updateBook(Guid id, BookDto book )
        {
            var bookNow = _bookReadRepos.getById(id);
            if (bookNow != null)
            {
                bookNow.BookTitle = book.BookName;
                bookNow.Price = book.BookPrices;
                bookNow.CoverImage = book.urlImg;
                bookNow.StockQuantity = book.Stock;
                List<Author> listAuthor = new List<Author>();
                foreach (Guid idAuthor in book.AuthorIds)
                {
                    var author = _authorRepos.getById(idAuthor);
                    if (author != null)
                    {
                        listAuthor.Add(author);
                    }
                }
                List<Genre> listGenre = new List<Genre>();
                foreach (Guid idGenre in book.GenreIds)
                {
                    var genre = _genreRepos.GetById(idGenre);
                    if (genre != null)
                    {
                        listGenre.Add(genre);
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
