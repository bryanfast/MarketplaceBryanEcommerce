namespace MarketplaceBryanEcommerce.Client.Services.Order_Service
{
    public interface IOrderService
    {
        Task <String>PlaceOrder();
        Task<List<OrderOverviewResponse>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
