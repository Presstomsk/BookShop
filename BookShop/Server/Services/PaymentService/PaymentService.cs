using BookShop.Server.Migrations;
using BookShop.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Stripe;
using Stripe.Checkout;

namespace BookShop.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        public PaymentService()
        {
            StripeConfiguration.ApiKey = "sk_test_51MyFbKI7kGA2rr8BymOjQawxfkaTP72x8YY5PVAx8cDCYL2q4IWcIlakfEqhxEa9Wx5gr8v8INYAnUn4mbnDjeCS002WaEzpHM";
        }

        public Session CreateCheckoutSession(List<CartItem> cartItems)
        {
            var lineItems = new List<SessionLineItemOptions>();

            cartItems.ForEach(ci => lineItems.Add(new SessionLineItemOptions
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
                SuccessUrl = "https://localhost:7176/order-success",
                CancelUrl = "https://localhost:7176/cart",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            return session;     
        }
    }
}
