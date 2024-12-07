using BookData.DataTransferObjects;

namespace BookBlazorWasmCustomer.Services
{
    public interface IOrderApiClient
    {
        Task<bool> CreateOrder(List<BookEntryDto> bookEntries);
    }
}
