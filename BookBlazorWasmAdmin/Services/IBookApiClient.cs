using BookData.Request.BookRequest;
using BookData.ViewModels;

namespace BookBlazorWasmAdmin.Services
{
    public interface IBookApiClient
    {
        Task<List<BookVM>> GetAllBook();
        Task<BookVM> GetBook(Guid id);
        Task CreateBook(BookCreateRequest bookCreateRequest);
        Task DeleteBook(Guid id);
    }
}
