using ShopModels.Controllers.DBConnection;
using ShopModels.Models;
using ShopPages.Components.Models;
namespace ShopModels.Controllers.Service
{
    public class ProductTypeService
    {
        dbProductType _dbproductType;
        List<ProductType> Products;
        public ProductTypeService()
        {
            _dbproductType = new dbProductType();
        }
        public virtual void Create(ProductType productType)
        {
            _dbproductType.Create(productType);
        }
       public virtual List<ProductType> Read()
       {
            Products = _dbproductType.Read();
            return Products;
       }
       public virtual void Update(ProductType productType) 
       {
            _dbproductType.Update(productType);
       }
       public virtual void Delete(ProductType productType)
       {
            _dbproductType.Delete(productType);
       }
    }
}
