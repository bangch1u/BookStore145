using BookData.Data.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace BookBlazorWasmAdmin.Services
{
    public class GenreApiClient : IGenreApiClient
    {
        private readonly HttpClient _httpClient;
        private NavigationManager navigation;

        public GenreApiClient(HttpClient httpClient, NavigationManager navigation)
        {
            _httpClient = httpClient;
            this.navigation = navigation;
        }
        private string url = "/api/genres";
        
        public async Task<bool> CreateGenre(Genre genre)
        {
            var content = new StringContent(JsonConvert.SerializeObject(genre), 
                System.Text.Encoding.UTF8, "Application/json");
            var response = await _httpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteGenre(Guid id)
        {
           var response = await _httpClient.DeleteAsync(url+$"/{id}");
            if (response.IsSuccessStatusCode)
                return true;         
            else 
                return false;
        }

        public async Task<List<Genre>> GetAllGenre()
        {
            return await _httpClient.GetFromJsonAsync<List<Genre>>("/api/genres");
        }

        public Task<Genre> GetGenreById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}
