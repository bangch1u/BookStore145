using BookApi.Services;
using BookData.Data.Entities;
using BookData.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BookApi.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;
        private readonly IWebHostEnvironment _evn;
        public AuthorController(IAuthorService service, IWebHostEnvironment evn)
        {
            _service = service;
            _evn = evn;
        }
        [HttpGet]
        public IActionResult getAllAuthors()
        {
            var lstAuthor = _service.getAll();
           
            if (lstAuthor != null)
            {
                foreach (var author in lstAuthor)
                {
                    if (author.AuthorImage != null)
                    {
                        author.AuthorImage = $"{Request.Scheme}://{Request.Host}/AuthorImg/{author.AuthorImage}";
                    }
                }
                return Ok(lstAuthor);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult getAuthor(Guid id)
        {
            var author = _service.getById(id);
            if (author != null)
            {
                return Ok(author);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult createAuthor([FromForm]AuthorDto authorDto)
        {
            var untrustedFIleName = authorDto.AuthorImgFile.FileName;
            string AuthorImgFolder = Path.Combine(_evn.WebRootPath, "AuthorImg");

            if (!Directory.Exists(AuthorImgFolder))
            {
                Directory.CreateDirectory(AuthorImgFolder); 
            }
            var trustedFileNameForDisplay = WebUtility.HtmlDecode(untrustedFIleName);
            string trustedFileNameForFileStorage = Path.GetRandomFileName();
            if(authorDto.AuthorImgFile != null && authorDto.AuthorImgFile.Length > 0)
            {
                var fileExtension = Path.GetExtension(authorDto.AuthorImgFile.FileName);

                trustedFileNameForFileStorage = Path.ChangeExtension(Path.GetRandomFileName(), fileExtension);

                string newFilePath = Path.Combine(AuthorImgFolder, trustedFileNameForFileStorage);
                using(FileStream fs = new(newFilePath, FileMode.Create))
                {
                    authorDto.AuthorImgFile.CopyTo(fs);
                }  

            }
            Author author = new ()
            {
                AuthorId = Guid.NewGuid(),
                AuthorName = authorDto.AuthorName,
                Birth = authorDto.Birth,
                Desciption = authorDto.Desciption,
                AuthorImage = trustedFileNameForFileStorage,
            };
            
            var status = _service.createAuthor(author);
            if (status)
            {
                return StatusCode(201, author);
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public IActionResult updateAuthor(Guid id, Author author)
        {
            var status = _service.updateAuthor(id, author);
            if (status)
            {
                return StatusCode(200, author);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteAuthor(Guid id)
        {
            var status = _service.deleteAuthor(id);
            if (status)
            {
                return StatusCode(200);
            }
            return BadRequest();
        }
    }
}
