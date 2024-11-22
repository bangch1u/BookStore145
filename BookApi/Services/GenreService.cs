using BookData.Data.Entities;
using BookData.Repositories;
using BookData.Repositories.CommonRepos;

namespace BookApi.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenericRepository<Genre> _genreCUDRepos;
        private readonly IGenreRepos _genreReadRepos;
        public GenreService(IGenericRepository<Genre> genreCUDRepos,
            IGenreRepos genreReadRepos)
        {
            _genreCUDRepos = genreCUDRepos;
            _genreReadRepos = genreReadRepos;
        }

        

        public void createGenre(Genre Genre)
        {
            Genre.Id = Guid.NewGuid();
            _genreCUDRepos.Insert(Genre);
            _genreCUDRepos.Save();
        }

        public void deleteGenre(Guid id)
        {
            _genreCUDRepos.Delete(getById(id));
            _genreCUDRepos.Save();
        }

        public List<Genre> getAll()
        {
            return _genreReadRepos.GetAll();
        }

        public Genre getById(Guid id)
        {
            return _genreReadRepos.GetById(id);
        }

        public void updateGenre(Guid id, Genre Genre)
        {
            var bgNow = _genreReadRepos.GetById(id);
            if (bgNow != null)
            {
                bgNow.GenreName = Genre.GenreName;
                bgNow.AgeLimit = Genre.AgeLimit;
                _genreCUDRepos.Update(bgNow);
                _genreCUDRepos.Save();
            }
        }
    }
}
