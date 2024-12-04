using BookApi.Services;
using BookData.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/oders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllOrder()
        {
            return Ok(_service.GetAllOrder());
        }
        [HttpPost]
        public IActionResult CreateOrder(List<BookEntryDto> bookIds)
        {
            var result = _service.Create(bookIds);
            if (result == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
