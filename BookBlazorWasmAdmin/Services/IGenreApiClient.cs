using BookData.Data.Entities;

namespace BookBlazorWasmAdmin.Services
{
    public interface IGenreApiClient 
    {
        Task<List<Genre>> GetAllGenre();
    }
}
