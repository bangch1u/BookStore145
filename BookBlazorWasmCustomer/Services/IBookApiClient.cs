using BookData.ViewModels;

namespace BookBlazorWasmCustomer.Services
{
    public interface IBookApiClient
    {
        Task<List<BookVM>> getAllBook(int page); 
    }
}
