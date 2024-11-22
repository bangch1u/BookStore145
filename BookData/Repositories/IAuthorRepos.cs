using BookData.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Repositories
{
    public interface IAuthorRepos 
    {
        List<Author> getAll();
        Author getById(Guid id);
    }
}
