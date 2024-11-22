using BookData.DataTransferObjects;
using BookData.Request.BookRequest;
using BookData.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text;
using Newtonsoft.Json;
using BookData.Data.Entities;

namespace BookBlazorWasmAdmin.Services
{
    public class BookApiClient : IBookApiClient
    {
        private readonly HttpClient _httpClient;
        private NavigationManager _navigationManager;
        public BookApiClient(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }


        private string url = "/api/books";
        public async Task CreateBook(BookCreateRequest bookCreateRequest)
        {
           

            using var content = new MultipartFormDataContent();

            // Thêm dữ liệu đơn giản (string, số, ngày tháng)
            content.Add(new StringContent(bookCreateRequest.BookName ?? ""), "BookName");
            content.Add(new StringContent(bookCreateRequest.BookPrices.ToString()), "BookPrices");
            content.Add(new StringContent(bookCreateRequest.Stock.ToString()), "Stock");
            content.Add(new StringContent(bookCreateRequest.PublicationYear.ToString("yyyy-MM-dd")), "PublicationYear");

            // Thêm danh sách AuthorIds
            if (bookCreateRequest.AuthorIds != null)
            {
                foreach (var authorId in bookCreateRequest.AuthorIds)
                {
                    content.Add(new StringContent(authorId.ToString()), "AuthorIds");
                }
            }

            // Thêm danh sách GenreIds
            if (bookCreateRequest.GenreIds != null)
            {
                foreach (var genreId in bookCreateRequest.GenreIds)
                {
                    content.Add(new StringContent(genreId.ToString()), "GenreIds");
                }
            }

            // Thêm file ImgFile
            if (bookCreateRequest.ImgFile != null)
            {
                var fileContent = new StreamContent(bookCreateRequest.ImgFile.OpenReadStream());
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(bookCreateRequest.ImgFile.ContentType);
                content.Add(fileContent, "ImgFile", bookCreateRequest.ImgFile.Name);
            }

            // Gửi request tới API
            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                // Xử lý khi thành công
                Console.WriteLine("Book created successfully!");
                _navigationManager.NavigateTo("/book/list");
            }
            else
            {
                // Xử lý lỗi
                Console.WriteLine("Error creating book.");
            }


        }

        public async Task<List<BookVM>> GetAllBook()
        {
            var result = await _httpClient.GetFromJsonAsync<List<BookVM>>(url);
            return result;
        }

        public async Task<BookVM> GetBook(Guid id)
        {
            var book = await _httpClient.GetFromJsonAsync<BookVM>($"/api/books/{id}");
            return book;
        }
        public async Task DeleteBook(Guid id)
        {
            var response = await _httpClient.DeleteAsync(url + $"/{id}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Delete Success!");
                _navigationManager.NavigateTo("/book/list");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
        }
    }
}
