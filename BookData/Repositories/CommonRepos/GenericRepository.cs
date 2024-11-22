using BookData.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Repositories.CommonRepos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private BookDbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(BookDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity); ;
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
