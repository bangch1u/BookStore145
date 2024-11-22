using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookData.Data.Entities
{
    public class Author
    {
        [Key]
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }  
        public DateTime Birth {  get; set; }    
        public string AuthorImage { get; set; }
        public string Desciption { get; set; }
        [JsonIgnore]
        public ICollection<Book>? Books { get; set; }
    }
}
