using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Data.Entities
{
    public class Publisher
    {
        [Key]
        public Guid PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }    
    }
}
