using BookData.Data.Entities;
using System.Net.Http.Json;

namespace BookBlazorWasmAdmin.Services
{
    public class GenreApiClient : IGenreApiClient
    {
        private readonly HttpClient _httpClient;

        public GenreApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Genre>> GetAllGenre()
        {
            return await _httpClient.GetFromJsonAsync<List<Genre>>("/api/genres");
        }
    }
}
