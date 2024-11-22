using BookApi.Services;
using BookData.Data.Entities;
using BookData.DataTransferObjects;
using BookData.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookApi.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        private List<string> NA = new List<string> { "N/A" };
        private readonly IWebHostEnvironment _env;

        public BookController(IWebHostEnvironment env,
            IBookService bookService)
        {
            _env = env;
            _service = bookService;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var lstBook = _service.getAll();
            if (lstBook != null)
            {

                var bookVM = lstBook.Select(x => new BookVM()
                {
                    BookId = x.BookId,
                    BookName = x.BookTitle,
                    BookPrices = x.Price,
                    Stock = x.StockQuantity,
                    UrlImage = x.CoverImage != null ? $"{Request.Scheme}://{Request.Host}/Uploads/{x.CoverImage}" : "N/A",
                    AuthorNames = x.Authors != null && x.Authors.Count > 0 ? x.Authors.Select(a => a.AuthorName).ToList() : NA,
                    PublicationYear = x.PublicationYear,
                    Genres = x.Genres != null && x.Genres.Count > 0 ? x.Genres.Select(g => g.GenreName).ToList() : NA,
                });
                return Ok(bookVM);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult getBook([FromRoute] Guid id)
        {
            var book = _service.getById(id);
            if (book != null)
            {
                return Ok(new BookVM()
                {
                    BookId = book.BookId,
                    BookName = book.BookTitle,
                    BookPrices = book.Price,
                    Stock = book.StockQuantity,
                    UrlImage = book.CoverImage != null ? $"{Request.Scheme}://{Request.Host}/Uploads/{book.CoverImage}" : "N/A",
                    AuthorNames = book.Authors != null && book.Authors.Count > 0 ? book.Authors.Select(a => a.AuthorName).ToList() : NA,
                    PublicationYear = book.PublicationYear,
                    Genres = book.Genres != null && book.Genres.Count > 0 ? book.Genres.Select(g => g.GenreName).ToList() : NA,
                });
                 
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult createBook([FromForm]BookDto bookdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string trustedFileNameForFileStorage;
            var untrustedFileName = bookdto.ImgFile.FileName;
            string uploadsFolder = Path.Combine(_env.WebRootPath, "Uploads");
            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }
            var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);//mã hóa tên file 

            trustedFileNameForFileStorage = Path.GetRandomFileName();
            if (bookdto.ImgFile != null && bookdto.ImgFile.Length > 0)
            {
                // Lấy phần mở rộng của tệp gốc
                var fileExtension = Path.GetExtension(bookdto.ImgFile.FileName);

                // Tạo tên tệp mới và đảm bảo có phần mở rộng
                trustedFileNameForFileStorage = Path.ChangeExtension(Path.GetRandomFileName(), fileExtension);

                string newFilePath = Path.Combine(uploadsFolder, trustedFileNameForFileStorage);
                using (FileStream fs = new(newFilePath, FileMode.Create))
                {
                    bookdto.ImgFile.CopyTo(fs);
                }

                bookdto.urlImg = trustedFileNameForFileStorage;
            }

            var bookNew = _service.createBook(bookdto);
            if (bookNew)
            {
                return StatusCode(201, bookdto);
            }
            else
            {
                return BadRequest(bookdto);
            }
            

        }
        [HttpPut("{id}")]
        public IActionResult updateBook(Guid id, BookDto bookUpdate)
        {
            var bookNew = _service.updateBook(id, bookUpdate);
            return StatusCode(200, bookUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteBook(Guid id)
        {
            if (_service.deleteBook(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
