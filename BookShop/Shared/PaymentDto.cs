using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Shared
{
    public class PaymentDto
    {
        public string? Email { get; set; }
        public List<CartItem>? CartItems { get; set; }
    }
}