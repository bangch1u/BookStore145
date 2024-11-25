using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.DataTransferObjects
{
    public class AuthorDto
    {
        public string AuthorName { get; set; }
        public DateTime Birth { get; set; }
        public IFormFile AuthorImgFile { get; set; }
        public string Desciption { get; set; }
    }
}
