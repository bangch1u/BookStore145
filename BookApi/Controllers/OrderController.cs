using BookApi.Services;
using BookData.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/orders")]
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
        public IActionResult CreateOrder([FromBody]List<BookEntryDto> bookIds)
        {
           
            if (bookIds == null || !bookIds.Any())
            {
                return BadRequest("Danh sách rỗng hoặc không hợp lệ.");
            }

            var result = _service.Create(bookIds);
            if (result)
            {
                return Ok("Đặt hàng thành công.");
            }
            else
            {
                return BadRequest("Đặt hàng thất bại.");
            }

        }
    }
}
