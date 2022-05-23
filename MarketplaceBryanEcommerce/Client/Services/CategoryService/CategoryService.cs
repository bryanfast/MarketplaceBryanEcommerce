namespace MarketplaceBryanEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get; set; }

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category");
            if(response != null && response.Data!=null)
                Categories= response.Data;
        }

        public async Task<ServiceResponse<Category>> GetCategory(int categoryId)
        {

            var response = await _http.GetFromJsonAsync<ServiceResponse<Category>>($"api/category/{categoryId}");
            return response!;
        }
    }
}
