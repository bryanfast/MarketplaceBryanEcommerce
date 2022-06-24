global using MarketplaceBryanEcommerce.Shared;
global using System.Net.Http.Json;
global using Blazored.LocalStorage;
global using MarketplaceBryanEcommerce.Client.Services.AuthService;
global using MarketplaceBryanEcommerce.Client.Services.CartService;
global using MarketplaceBryanEcommerce.Client.Services.CategoryService;
global using MarketplaceBryanEcommerce.Client.Services.Order_Service;
global using MarketplaceBryanEcommerce.Client.Services.ProductService;
global using MarketplaceBryanEcommerce.Client.Services.ProductTypeService;
global using Microsoft.AspNetCore.Components.Authorization;
global using MarketplaceBryanEcommerce.Client.Services.AddressService;
using MarketplaceBryanEcommerce.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// Servicio de Local Storage
builder.Services.AddBlazoredLocalStorage();

//Servicios Locales
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductTypeService, ProductTypeService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider,CustomAuthStateProvider>();

await builder.Build().RunAsync();
