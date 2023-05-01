using BookShop.Shared;
using Stripe.Checkout;

namespace BookShop.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Session CreateCheckoutSession(PaymentDto paymentDto);
    }
}
