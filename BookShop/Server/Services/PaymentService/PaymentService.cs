using BookShop.Server.Data;
using BookShop.Server.Services.OrderService;
using BookShop.Shared;
using Stripe;
using Stripe.Checkout;

namespace BookShop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly IOrderService _orderService;

        public PaymentService(IOrderService orderService)
        {
            StripeConfiguration.ApiKey = "sk_test_51MyFbKI7kGA2rr8BymOjQawxfkaTP72x8YY5PVAx8cDCYL2q4IWcIlakfEqhxEa9Wx5gr8v8INYAnUn4mbnDjeCS002WaEzpHM";
            _orderService = orderService;
        }

        public Session CreateCheckoutSession(PaymentDto paymentDto)
        {
            var lineItems = new List<SessionLineItemOptions>();

            var orderId = Guid.NewGuid();

            paymentDto?.CartItems?.ForEach(ci => lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmountDecimal = ci.Price * 100,
                    Currency = "usd",                    
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = ci.ProductTitle,
                        Images = new List<string> { ci.Image ?? "https://via.placeholder.com/300x300" }                     
                    }
                },
                Quantity = ci.Quantity
            }));

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = $"https://localhost:7176/order-success/{orderId}",
                CancelUrl = $"https://localhost:7176/order-fail/{orderId}",
                PaymentIntentData = new SessionPaymentIntentDataOptions
                {
                    Description = orderId.ToString()
                }
            };

            options.CustomerEmail = paymentDto?.Email;
            
            var service = new SessionService();
            Session session = service.Create(options);
            _orderService.CreateOrder(orderId, paymentDto?.Email);
            return session;     
        }        
    }   
}
