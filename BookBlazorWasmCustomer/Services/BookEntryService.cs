namespace BookBlazorWasmCustomer.Services
{
    public class BookEntryService
    {
      
       
        public List<BookEntry> BookEntrys { get; private set; } = new List<BookEntry>();

        public void AddBookEntry(Guid bookId)
        {
           var bookEntryNew = new BookEntry();
           bookEntryNew.BookEntryId = bookId;
            BookEntrys.Add(bookEntryNew);   


        }

    }
    public class BookEntry
    {
        public Guid BookEntryId { get; set; }
        public int Quantity { get; set; }

        public BookEntry()
        {
              Quantity = 0;
        }
    }

}
