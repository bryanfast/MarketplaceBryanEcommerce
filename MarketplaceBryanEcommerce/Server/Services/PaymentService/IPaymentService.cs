using Stripe.Checkout;

namespace MarketplaceBryanEcommerce.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<Session> CreateChekoutSesion();
        Task<ServiceResponse<bool>> FullfillOrder( HttpRequest request);

    }
}
