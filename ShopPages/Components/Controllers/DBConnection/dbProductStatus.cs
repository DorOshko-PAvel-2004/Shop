using ShopModels.Models;
using ShopPages.Components.Models;
namespace ShopModels.Controllers.DBConnection
{
    public class dbProductStatus:CRUD<ProductStatus>
    {
        public WebSiteContext<ProductStatus> context { get; set; }
        public virtual void Create(ProductStatus product)
        {
            using (context = new WebSiteContext<ProductStatus>())
            {
                context.DataArray.Add(product);
                context.SaveChangesAsync();
            }
        }
        public virtual List<ProductStatus> Read()
        {
            using (context = new WebSiteContext<ProductStatus>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(ProductStatus product) 
        {
            using(context = new WebSiteContext<ProductStatus>())
            {
                context.DataArray.Update(product);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(ProductStatus product)
        {
            using(context = new WebSiteContext<ProductStatus>())
            {
                context.DataArray.Remove(product);
                context.SaveChangesAsync();
            }
        }
    }
}
