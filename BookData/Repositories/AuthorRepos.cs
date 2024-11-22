using BookData.Data.Context;
using BookData.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Repositories
{
    public class AuthorRepos : IAuthorRepos
    {
        private BookDbContext _db;

        public AuthorRepos(BookDbContext db)
        {
            _db = db;
        }

        public List<Author> getAll()
        {
            return _db.Authors.ToList();
        }

        public Author getById(Guid id)
        {
            return _db.Authors.Find(id);
        }
    }
}
