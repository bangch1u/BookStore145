using BookData.Data.Entities;
using BookData.DataTransferObjects;
using BookData.Repositories;

namespace BookApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepos _orderRepos;
        private readonly IBookRepos _bookRepos;
        public OrderService(IOrderRepos orderRepos,
            IBookRepos bookRepos)
        {
            _orderRepos = orderRepos;
            _bookRepos = bookRepos;
        }

        public bool Create(List<BookEntryDto> bookIds)
        {
            var listBook = _bookRepos.getAll()
                .Where(b => bookIds.Select(bd => bd.BookId).Contains(b.BookId)).ToList();

            //kiểm tra tồn kho cho từng sách
            foreach (var bookEntry in bookIds)
            {
                var book = listBook.FirstOrDefault(b => b.BookId == bookEntry.BookId); 
                if(book == null || book.StockQuantity < bookEntry.Quantity || book.StockQuantity == 0)
                {
                    return false;
                }
            }
            return _orderRepos.Create(bookIds);
        }

        public List<Order> GetAllOrder()
        {
           return _orderRepos.GetAllOrder();
        }
    }
}
