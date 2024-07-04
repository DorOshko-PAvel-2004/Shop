using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPages.Components.Models
{
    [PrimaryKey(nameof(CategoryID))]
    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<ProductType> ProductTypes { get; set; }
        public ProductCategory()
        {

        }
    }
}
