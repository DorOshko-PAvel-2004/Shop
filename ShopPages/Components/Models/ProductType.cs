using Microsoft.EntityFrameworkCore;
using ShopModels.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPages.Components.Models
{
    [PrimaryKey(nameof(TypeID))]
    public class ProductType
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        [ForeignKey("ProductCategory")]
        public int CategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<Product> Products { get; set; }
        public ProductType() { }
    }
}
