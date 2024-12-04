using BookData.Data.Context;
using BookData.Data.Entities;
using BookData.DataTransferObjects;
using BookData.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Repositories
{
    public class OrderRepos : IOrderRepos
    {
        private readonly BookDbContext _context;

        public OrderRepos(BookDbContext context)
        {
            _context = context;
        }

        public bool Create(List<BookEntryDto> bookIds)
        {
            var order = new Order()
            {
                OrderId = Guid.NewGuid(),
                Status = OrderStatus.InTheCart,
                PurchaseTime = DateTime.Now,
                TotalQuantity = 0,
                TotalPrice = 0,
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            foreach(var bookEntry in bookIds)
            {
                //tìm sách theo bookIds
                var book = _context.Books.FirstOrDefault( b => b.BookId == bookEntry.BookId ); 
                if(book != null && book.StockQuantity >= bookEntry.Quantity)
                {
                    //tạo đối tượng OrderDetail cho mỗi BookEntry
                    var orderDetail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        BookId = book.BookId,
                        Quantity = bookEntry.Quantity,
                        Price = bookEntry.Quantity * book.Price,
                    };

                    _context.OrderDetails.Add(orderDetail);
                    _context.SaveChanges();

                    //thêm OrderDEtail vào danh sách
                    order.OrderDetails.Add(orderDetail);
                    _context.Orders.Update(order);
                    _context.SaveChanges();

                    //giảm số lượng tồn kho
                    book.StockQuantity -= bookEntry.Quantity;
                    //tăng total quantity in order
                    order.TotalQuantity = order.TotalQuantity +  bookEntry.Quantity;
                    //tăng totalPrice in order
                    order.TotalPrice +=  bookEntry.Quantity * book.Price;
                    _context.Orders.Update(order);
                    _context.SaveChanges();
                    _context.Books.Update(book);
                    _context.SaveChanges();
                  
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public List<Order> GetAllOrder()
        {
            return _context.Orders.Include(od => od.OrderDetails).ThenInclude(b => b.Book).ToList();
        }
    }
}
