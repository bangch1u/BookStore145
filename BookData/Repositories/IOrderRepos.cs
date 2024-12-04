using BookData.Data.Entities;
using BookData.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Repositories
{
    public interface IOrderRepos
    {
        List<Order> GetAllOrder();

        bool Create(List<BookEntryDto> bookIds);
    }
}
