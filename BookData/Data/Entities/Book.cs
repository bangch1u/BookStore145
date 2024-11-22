using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Data.Entities
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; } 
        public string BookTitle { get; set; }
        public double Price { get; set; }
        public string? CoverImage { get; set; }
        public DateTime PublicationYear { get; set; }
        public string? BookQRCode { get; set; }
        public int StockQuantity { get; set; }
        public string? Desciption { get; set; }
        public ICollection<Author>? Authors { get; set; }
        //public ICollection<Publisher > Publishers { get; set; }
        public ICollection<Genre>? Genres { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }
    }
}
