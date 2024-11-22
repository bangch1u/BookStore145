using BookApi.Services;
using BookData.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _service;
        public GenreController(IGenreService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult getAll()
        {
            var listGenre = _service.getAll();
            if (listGenre != null)
            {
               return Ok(listGenre);
            }
            return NotFound();
        }
        [HttpGet("{id}")]
        public IActionResult getGenre(Guid id)
        {
            var genre = _service.getById(id);
            if (genre != null)
            {
                return Ok(genre);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult createGenre(Genre genre)
        {
            _service.createGenre(genre);
            return StatusCode(201, genre);
        }
        [HttpPut("{id}")]
        public IActionResult editGenre(Guid id, Genre genre)
        {
            _service.updateGenre(id, genre);
            return Ok(genre);
        }
        [HttpDelete("{id}")]
        public IActionResult deleteGenre(Guid id)
        {
            _service.deleteGenre(id);
            return Ok();
        }
    }
}
