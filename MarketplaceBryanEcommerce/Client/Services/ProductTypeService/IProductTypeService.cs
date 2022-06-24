namespace MarketplaceBryanEcommerce.Client.Services.ProductTypeService
{
    public interface IProductTypeService
    {
        event Action OnChange;
        public List<ProductType> ProductTypes { get; set; }
        Task GetProductTypes();
        ProductType CreateNewProductType();
        Task UpdateProductType(ProductType productType);
        Task AddProductType(ProductType productType);
    }
}
