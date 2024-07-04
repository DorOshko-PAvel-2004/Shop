using ShopModels.Controllers.DBConnection;
using ShopModels.Models;
namespace ShopModels.Controllers.Service
{
    public class ProductService
    {
        dbProduct _dbproduct;
        List<Product> Products;
        public ProductService()
        {
            _dbproduct = new dbProduct();
        }
        public virtual void Create(Product product)
        {
            _dbproduct.Create(product);
        }
       public virtual List<Product> Read()
       {
            Products = _dbproduct.Read();
            return Products;
       }
       public virtual void Update(Product product) 
       {
            _dbproduct.Update(product);
       }
       public virtual void Delete(Product product)
       {
            _dbproduct.Delete(product);
       }
    }
}
