namespace MarketplaceBryanEcommerce.Server.Services.Order_Service
{
    public interface IOrderService
    {
        Task <ServiceResponse<bool>> PlaceOrder(int userId);
        Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders();
        Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId);
    }
}
