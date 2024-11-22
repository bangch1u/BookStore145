using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.ViewModels
{
    public class BookVM
    {
        public Guid BookId { get; set; }
        public string BookName { get; set; }
        public double BookPrices { get; set; }
        public int Stock {  get; set; } 
        public DateTime PublicationYear { get; set; }
        public string UrlImage { get; set; }
        public List<string> AuthorNames { get; set; }
        public List<string> Genres { get; set; }
    }
}
