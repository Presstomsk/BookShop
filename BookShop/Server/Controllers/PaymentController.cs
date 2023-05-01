using BookShop.Server.Services.PaymentService;
using BookShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{    
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost("checkout")]
        public ActionResult CreateCheckoutSession(PaymentDto paymentDto)
        {
            var session = _paymentService.CreateCheckoutSession(paymentDto);
            return Ok(session.Url);
        }
    }
}
