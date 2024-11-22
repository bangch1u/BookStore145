using BookData.Data.Entities;

namespace BookApi.Services
{
    public interface IGenreService
    {
        List<Genre> getAll();
        Genre getById(Guid id);
        void createGenre(Genre Genre);
        void updateGenre(Guid id, Genre Genre);
        void deleteGenre(Guid id);
    }
}
