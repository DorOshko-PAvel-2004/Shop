using Microsoft.EntityFrameworkCore;
using ShopPages.Components.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ShopModels.Models
{
    [PrimaryKey(nameof(ProductID))]
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        [ForeignKey("ProductType")]
        public int TypeID { get; set; }
        [ForeignKey("Company")]
        public int CompanyID { get; set; }
        public double Price { get; set; }
        [ForeignKey("ProductStatus")]
        public int StatusID { get; set; }
        public Company Company { get; set; }
        public ProductType ProductType { get; set; }
        public ProductStatus ProductStatus { get; set; }
        public Product() 
        {

        }
        public Product(IDataReader reader)
        {
            ProductID = int.Parse(reader["ProductID"].ToString());
            Name = reader["Name"].ToString();
            TypeID = int.Parse(reader["TypeID"].ToString());
            CompanyID = int.Parse(reader["CompanyID"].ToString());
            Price = double.Parse(reader["Price"].ToString());
            StatusID = int.Parse(reader["StatusID"].ToString());
        }
    }
}
