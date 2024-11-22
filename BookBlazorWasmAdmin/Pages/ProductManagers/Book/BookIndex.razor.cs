using BookBlazorWasmAdmin.Services;
using BookData.DataTransferObjects;
using BookData.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BookBlazorWasmAdmin.Pages.ProductManagers.Book
{
    public partial class BookIndex
    {
        [Inject] IBookApiClient _bookApiClient { get; set; }
        public List<BookVM> Books;
        //[Parameter] public string id { get; set; }  
        protected override async Task OnInitializedAsync()
        {
            Books = await _bookApiClient.GetAllBook();
        }
        private async Task RemoveBook(Guid id)
        {
            await _bookApiClient.DeleteBook(id);
            Books = await _bookApiClient.GetAllBook();
        }
    }
}
