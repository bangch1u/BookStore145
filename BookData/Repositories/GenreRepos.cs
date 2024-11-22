using BookData.Data.Context;
using BookData.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Repositories
{
    public class GenreRepos : IGenreRepos
    {
        private BookDbContext _db;

        public GenreRepos(BookDbContext db)
        {
            _db = db;
        }

        public List<Genre> GetAll()
        {
            return _db.Genres.ToList();
        }

        public Genre GetById(Guid id)
        {
            return _db.Genres.Find(id);
        }
    }
}
