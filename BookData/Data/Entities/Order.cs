using BookData.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Data.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }   
        public int TotalQuantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseTime { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
