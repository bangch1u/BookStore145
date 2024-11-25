using BookData.Data.Entities;
using System.Net.Http.Json;

namespace BookBlazorWasmAdmin.Services
{
    public class AuthorApiClient : IAuthorApiClient
    {
        private readonly HttpClient _httpClient;

        public AuthorApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        string url = "/api/authors";
        public async Task<List<Author>> GetAllAuthor()
        {
            return await _httpClient.GetFromJsonAsync<List<Author>>(url);
        }

        public async Task<bool> DeleteAuthor(Guid id)
        {
            var response = await _httpClient.DeleteAsync(url + $"/{id}");
            if(response.IsSuccessStatusCode) return true;
            else return false;
        }
    }
}
