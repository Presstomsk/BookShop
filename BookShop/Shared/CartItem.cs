namespace BookShop.Shared
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int EditionId { get; set; }
        public string? ProductTitle { get; set; }
        public string? EditionName { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
    }
}
