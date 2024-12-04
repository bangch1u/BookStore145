using BookData.ViewModels;
using System.Net.Http.Json;

namespace BookBlazorWasmCustomer.Services
{
    public class BookApiClient : IBookApiClient
    {

        private readonly string url = "/api/books";
        private readonly HttpClient _httpClient;

        public BookApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<BookVM>> getAllBook(int page)
        {
            var response = await _httpClient.GetAsync($"api/books/paged?page={page}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<BookVM>>();
            }
            return new List<BookVM>();
        }
    }
}
