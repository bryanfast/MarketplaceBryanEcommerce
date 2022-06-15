﻿namespace MarketplaceBryanEcommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }
        public List<Category> Categories { get; set; }
        public List<Category> AdminCategories { get; set; } = new List<Category>();

        public event Action Onchange;

        public async Task AddCategory(Category category)
        {
            var response = await _http.PostAsJsonAsync("api/category/admin", category);
            AdminCategories = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
            await GetCategories();
            Onchange.Invoke();
        }

        public Category CreateNewCategory()
        {
            var newCategory = new Category
            {
                IsNew = true,
                Editing = true,
            };
            AdminCategories.Add(newCategory); ;
            Onchange.Invoke();
            return newCategory;
        }

        public async Task DeleteCategory(int id)
        {
            var response = await _http.DeleteAsync($"api/category/admin/{id}");
            AdminCategories = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
            await GetCategories();
            Onchange.Invoke();

        }

        public async Task GetAdminCategories()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/category/admin");
            if (response != null && response.Data != null)
                AdminCategories = response.Data;
        }

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

        public async Task UpdateCategory(Category category)
        {
            var response = await _http.PutAsJsonAsync("api/category/admin", category);
            AdminCategories = (await response.Content.ReadFromJsonAsync<ServiceResponse<List<Category>>>()).Data;
            await GetCategories();
            Onchange.Invoke();
        }
    }
}
