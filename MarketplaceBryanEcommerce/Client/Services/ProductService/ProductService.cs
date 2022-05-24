
namespace MarketplaceBryanEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public event Action ProductsChanged;
        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; }= "Cargando Productos";

        public int CurrentPage { get; set; } = 1;
        public int PageCount {  get; set; } = 0;
        public string LastSearch { get; set; } = string.Empty;

        public async  Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result!;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl==null?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product"):
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}")
                ;
            if (result != null && result.Data != null)
                Products = result.Data;
            CurrentPage = 1;
            PageCount = 0;
            if (Products.Count == 0)
            {
                Message = "No se encontraron productos";
            }
            ProductsChanged.Invoke();
        }

        public async Task SearchProducts(string searchText,int page)
        {
            LastSearch = searchText;
            var result = await _http.GetFromJsonAsync<ServiceResponse<ProductSearchResult>>($"api/product/search/{searchText}/{page}");
            if(result!=null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if (Products.Count == 0) Message = "No se encontraron productos";
            ProductsChanged?.Invoke();
        }

        public async Task<List<string>> GetSearchProductSuggestion(string searchText)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/product/searchsuggestions/{searchText}");
            return result!.Data!;
        }
    }
}
