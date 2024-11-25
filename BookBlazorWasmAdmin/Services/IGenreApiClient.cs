using BookData.Data.Entities;

namespace BookBlazorWasmAdmin.Services
{
    public interface IGenreApiClient 
    {
        Task<List<Genre>> GetAllGenre();
        Task<Genre> GetGenreById(Guid id);
        Task<bool> CreateGenre(Genre genre);
        Task<bool> UpdateGenre(Genre genre);
        Task<bool> DeleteGenre(Guid id);
    }
}
