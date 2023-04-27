using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Shared
{
    public interface IExtendedProduct
    {
        int ProductId { get; set; }
        int EditionId { get; set; }
        string? Title { get; set; }
        string? Description { get; set; }
        string Image { get; set; }
        string? CategoryName { get; set; }
        string? EditionName { get; set; }        
        decimal Price { get; set; }        
        decimal OriginalPrice { get; set; }
        DateTime? DateCreated { get; set; }
        DateTime? DateUpdated { get; set; }
        int Views { get; set; }
    }
}
