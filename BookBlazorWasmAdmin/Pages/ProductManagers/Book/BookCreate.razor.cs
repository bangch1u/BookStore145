using BookData.Request.BookRequest;
using BookData.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using BookBlazorWasmAdmin.Services;
using BookData.Data.Entities;

namespace BookBlazorWasmAdmin.Pages.ProductManagers.Book
{
    public partial class BookCreate
    {
        [Inject] IAuthorApiClient authorApiClient { get; set; }
        [Inject] IGenreApiClient genreApiClient { get; set; }
        [Inject] IBookApiClient bookApiClient { get; set; }

   
        private List<Genre> Genres { get; set; }
        private List<Author> Authors { get; set; }
        private int maxAllowedFiles = int.MaxValue;
        //private long maxFileSize = long.MaxValue;
        private string fileName;
        private IBrowserFile imageFile;
        protected override async Task OnInitializedAsync()
        {
            Authors = await authorApiClient.GetAllAuthor();
            Genres = await genreApiClient.GetAllGenre();
        }
        private async Task HandleSubmit()
        {
            Book.ImgFile = imageFile;
            Console.WriteLine(Book.BookName);
            Console.WriteLine(Book.BookPrices);
            Console.WriteLine(Book.Stock);
            Console.WriteLine(Book.PublicationYear);
            foreach (var item in Book.GenreIds)
            {
                Console.WriteLine(item);
            }
            foreach (var item in Book.AuthorIds)
            {
                Console.WriteLine(item);
            }
            if(Book.ImgFile != null)
            {
                Console.WriteLine("Có ảnh");
            }
            else
            {
                Console.WriteLine("Không có ảnh");
            }
            await bookApiClient.CreateBook(Book);

        }
    }
}
