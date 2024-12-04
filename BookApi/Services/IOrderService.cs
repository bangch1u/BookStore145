using BookData.Data.Entities;
using BookData.DataTransferObjects;

namespace BookApi.Services
{
    public interface IOrderService
    {
        List<Order> GetAllOrder();

        bool Create(List<BookEntryDto> bookIds);
    }
}
