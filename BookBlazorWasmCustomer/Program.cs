using BookBlazorWasmCustomer;
using BookBlazorWasmCustomer.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using static BookBlazorWasmCustomer.Pages.MainPages.BooksPage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7177") });
builder.Services.AddScoped<IBookApiClient, BookApiClient>();
builder.Services.AddSingleton<BookEntryService>();
builder.Services.AddScoped<IOrderApiClient, OrderApiClient>();
await builder.Build().RunAsync();
