using BookData.Data.Context;
using BookData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Repositories
{
    public class BookRepos : IBookRepos
    {
        private BookDbContext _db;

        public BookRepos(BookDbContext db)
        {
            _db = db;
        }

        public List<Book> getAll()
        {
            return _db.Books.Include("Authors").Include("Genres").ToList();
        }

        public Book getById(Guid id)
        {
            var bookFind =  _db.Books.Include("Authors").Include("Genres").FirstOrDefault(b => b.BookId == id);
            if(bookFind != null)
            {
                return bookFind;
            }
            return null;
        }
    }
}
