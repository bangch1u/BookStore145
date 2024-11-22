using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Request.BookRequest
{
    public class BookCreateRequest
    {
        public string BookName { get; set; }
        public double BookPrices { get; set; }
        public int Stock { get; set; }
        public DateTime PublicationYear { get; set; }
        public IBrowserFile ImgFile { get; set; }
        public List<Guid> AuthorIds { get; set; }
        public List<Guid> GenreIds { get; set; }
    }
}
