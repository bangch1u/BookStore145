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

        public async Task<List<BookVM>> getAllBook()
        {
            return  await _httpClient.GetFromJsonAsync<List<BookVM>>(url);    
        }
    }
}
