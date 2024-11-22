using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.DataTransferObjects
{
    public class BookDto
    {
        public string BookName { get; set; }
        public double BookPrices { get; set; }
        public DateTime PublicationYear { get; set; }
        public int Stock {  get; set; } 
        public string? urlImg { get; set; }
        public IFormFile ImgFile { get; set; }
        public List<Guid>? AuthorIds { get; set; }
        public List<Guid>? GenreIds { get; set; }
    }
}
