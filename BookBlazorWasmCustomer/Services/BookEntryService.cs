using BookData.DataTransferObjects;

namespace BookBlazorWasmCustomer.Services
{
    public class BookEntryService
    {
      
       
        public List<BookEntryDto> BookEntrys { get; private set; } = new List<BookEntryDto>();

        public void AddBookEntry(Guid bookId)
        {
           var bookEntryNew = new BookEntryDto();
           bookEntryNew.BookId = bookId;
            BookEntrys.Add(bookEntryNew);   
        }
        public void RemoveBookEntrys()
        {
            BookEntrys.Clear();
        }

    }
   

}
