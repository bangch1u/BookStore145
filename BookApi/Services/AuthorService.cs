using BookData.Data.Entities;
using BookData.Repositories;
using BookData.Repositories.CommonRepos;

namespace BookApi.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IGenericRepository<Author> _authorCUDRepos;
        private readonly IAuthorRepos _authorReadRepos;

        public AuthorService(IGenericRepository<Author> authorRepos,
            IAuthorRepos authorReadRepos)
        {
            _authorCUDRepos = authorRepos;
            _authorReadRepos = authorReadRepos;
        }

        public bool createAuthor(Author author)
        {
            author.AuthorId = Guid.NewGuid();
            _authorCUDRepos.Insert(author);
            return _authorCUDRepos.Save();
        }

        public bool deleteAuthor(Guid id)
        {
            var author = _authorReadRepos.getById(id);
            if (author != null)
            {
                _authorCUDRepos.Delete(author);
                return _authorCUDRepos.Save();
            }
            return false;
        }

        public List<Author> getAll()
        {
            return _authorReadRepos.getAll();
        }

        public Author getById(Guid id)
        {
            return _authorReadRepos.getById(id);
        }

        public bool updateAuthor(Guid id, Author author)
        {
            var authorNow = _authorReadRepos.getById(id);
            if (authorNow != null)
            {
                authorNow.AuthorName = author.AuthorName;
                authorNow.Birth = author.Birth;
                _authorCUDRepos.Update(authorNow);
                return _authorCUDRepos.Save();
            }
            return false;
        }
    }
}
