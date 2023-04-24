using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Shared
{
    public class ExtendedProduct
    {
        public int ProductId { get; set; }
        public int EditionId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";       
        public string? CategoryName { get; set; }
        public string? EditionName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? DateUpdated { get; set; }
        public int Views { get; set; }
    }
}
