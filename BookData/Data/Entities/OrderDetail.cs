using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookData.Data.Entities
{
    public class OrderDetail
    {
        public Guid OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }   
        public double Price { get; set; }   
    }
}
