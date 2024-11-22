using BookBlazorWasmAdmin;
using BookBlazorWasmAdmin.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7177") });
builder.Services.AddScoped<IBookApiClient, BookApiClient>();  
builder.Services.AddScoped<IAuthorApiClient, AuthorApiClient>();
builder.Services.AddScoped<IGenreApiClient, GenreApiClient>();
await builder.Build().RunAsync();
