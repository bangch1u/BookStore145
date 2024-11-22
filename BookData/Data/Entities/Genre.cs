using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BookData.Data.Entities
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }
        public string GenreName { get; set; }
        public int AgeLimit { get; set; }
        [JsonIgnore]
        public ICollection<Book>? Books { get; set; }
    }
}
