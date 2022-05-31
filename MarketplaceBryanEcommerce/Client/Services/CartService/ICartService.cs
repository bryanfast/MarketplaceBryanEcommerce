namespace MarketplaceBryanEcommerce.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(CartItem cartItem);
        //Task<List<CartItem>> GetCartItems();
        Task<List<CartProductResponse>> GetCartProducts();
        Task UdpateQuantity(CartProductResponse product);
        Task RemoveItemCart(int productId, int productTypeId);
        Task StoreCartItems(bool emptyLoadCart); 
        Task GetCartItemsCount ();
    }
}
