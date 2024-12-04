using BookData.Data.Entities;
using BookData.DataTransferObjects;

namespace BookApi.Services
{
    public interface IBookService
    {
        List<Book> getAll();
        Book getById(Guid id);
        bool createBook(BookDto book);
        bool updateBook(Guid id, BookDto book);
        bool deleteBook(Guid id);

        List<Book> getAllPagedList(int page = 1);
    }
}
