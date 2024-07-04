using ShopModels.Models;
using ShopPages.Components.Models;
namespace ShopModels.Controllers.DBConnection
{
    public class dbProductType:CRUD<ProductType>
    {
        public WebSiteContext<ProductType> context { get; set; }
        public virtual void Create(ProductType product)
        {
            using (context = new WebSiteContext<ProductType>())
            {
                context.DataArray.Add(product);
                context.SaveChangesAsync();
            }
        }
        public virtual List<ProductType> Read()
        {
            using (context = new WebSiteContext<ProductType>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(ProductType product) 
        {
            using(context = new WebSiteContext<ProductType>())
            {
                context.DataArray.Update(product);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(ProductType product)
        {
            using(context = new WebSiteContext<ProductType>())
            {
                context.DataArray.Remove(product);
                context.SaveChangesAsync();
            }
        }
    }
}
