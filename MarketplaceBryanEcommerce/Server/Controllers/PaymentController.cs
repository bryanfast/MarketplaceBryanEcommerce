using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketplaceBryanEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout")]
        public async Task<ActionResult<string>> CreateCheckoutSession()
        {
            var session = await _paymentService.CreateChekoutSesion();
            return Ok(session.Url);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> FullFillOrder()
        {
            var response = await _paymentService.FullfillOrder(Request);
            if (!response.Success)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }
    }
}
