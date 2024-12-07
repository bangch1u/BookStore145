using BookData.DataTransferObjects;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace BookBlazorWasmCustomer.Services
{
    public class OrderApiClient : IOrderApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly BookEntryService _bookEntryService;
        public OrderApiClient(HttpClient httpClient,
            BookEntryService bookEntryService)
        {
            _httpClient = httpClient;
            _bookEntryService = bookEntryService;
        }

        public async Task<bool> CreateOrder(List<BookEntryDto> bookEntries)
        {
            var response = await _httpClient.PostAsJsonAsync("api/orders", bookEntries);

            if (response.IsSuccessStatusCode)
            {

                Console.WriteLine("Đặt hàng thành công.");
                _bookEntryService.RemoveBookEntrys();
                return true;
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Đặt hàng thất bại: {error}");
                return false;
            }

        }
    }
}
