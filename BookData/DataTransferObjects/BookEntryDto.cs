﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.DataTransferObjects
{
    public class BookEntryDto
    {
        public Guid BookId { get; set; }
        public int Quantity { get; set; }
        public BookEntryDto()
        {
            Quantity = 0;    
        }
    }
}
