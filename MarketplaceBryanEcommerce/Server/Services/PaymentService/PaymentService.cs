using Stripe;
using Stripe.Checkout;

namespace MarketplaceBryanEcommerce.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly ICartService _cartService;
        private readonly IAuthService _authService;
        private readonly IOrderService _orderService;
        const string secret = "whsec_03f6570a92c971287302c7846332a0451b182e392a8a1fdfb69b797900715553";

        public PaymentService(ICartService cartService,IAuthService authService, IOrderService orderService)
        {
            StripeConfiguration.ApiKey = "sk_test_51L6EOsD5vklIHPR63pMLN9nQdUHH2yJLF0FQkQf3MjOIdYnEAyEwfY2G11Mdkn5S4nhM07kr5V94FjGI10W3MGIK00UAdfqxya";
            _cartService = cartService;
            _authService = authService;
            _orderService = orderService;
        }
        public async Task<Session> CreateChekoutSesion()
        {
            var products = (await _cartService.GetDbCartProducts()).Data;
            var lineItems=new List<SessionLineItemOptions>();
            products.ForEach(product => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = product.Price * 100,
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = product.Title,
                        Images = new List<string>
                        {
                            product.ImageUrl
                        }
                    }
                },
                Quantity = product.Quantity,
            }));
            var options = new SessionCreateOptions
            {
                CustomerEmail = _authService.GetUserEmail(),
                ShippingAddressCollection = new SessionShippingAddressCollectionOptions
                { 
                    AllowedCountries=new List<string> {"CO"}
                },
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl="https://localhost:7278/order-success",
                CancelUrl="https://localhost:7278/cart",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }

        public async Task<ServiceResponse<bool>> FullfillOrder(HttpRequest request)
        {
            var json = await new StreamReader(request.Body).ReadToEndAsync();
            try {
                var stripeEvent = EventUtility.ConstructEvent(
                    json,
                    request.Headers["Stripe-Signature"],
                    secret);
                if (stripeEvent.Type == Events.CheckoutSessionCompleted)
                {
                    var session = stripeEvent.Data.Object as Session;
                    var user = await _authService.GetUserByEmail(session.CustomerEmail);
                    await _orderService.PlaceOrder(user.Id);
                }
                return new ServiceResponse<bool> { Data = true };
            } catch (StripeException e) {
                return new ServiceResponse<bool> { Data = false, Success = false, Message = e.Message };
            };
        }
    }
}
