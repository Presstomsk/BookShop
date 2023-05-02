using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop.Shared
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public OrderStatus Status { get; set; }
    }
}