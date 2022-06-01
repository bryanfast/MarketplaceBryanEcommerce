namespace MarketplaceBryanEcommerce.Server.Services.Order_Service
{
    public interface IOrderService
    {
        Task <ServiceResponse<bool>> PlaceOrder();
        Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders();
    }
}
