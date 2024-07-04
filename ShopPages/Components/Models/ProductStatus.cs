using Microsoft.EntityFrameworkCore;
using ShopModels.Models;

namespace ShopPages.Components.Models
{
    [PrimaryKey(nameof(StatusID))]
    public class ProductStatus
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }
        public List<Product> Products { get; set; }
        public ProductStatus()
        {

        }
    }
}
