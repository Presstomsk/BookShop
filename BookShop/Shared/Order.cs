using System.ComponentModel.DataAnnotations;

namespace BookShop.Shared
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public OrderStatus Status { get; set; }

    }
    public enum OrderStatus
    {
        Fail,
        Created,
        Success,
        Confirmed,
        Sent
    }
}