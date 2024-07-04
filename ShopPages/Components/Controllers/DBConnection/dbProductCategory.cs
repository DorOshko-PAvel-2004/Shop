using ShopModels.Models;
using ShopPages.Components.Models;
namespace ShopModels.Controllers.DBConnection
{
    public class dbProductCategory:CRUD<ProductCategory>
    {
        public WebSiteContext<ProductCategory> context { get; set; }
        public virtual void Create(ProductCategory product)
        {
            using (context = new WebSiteContext<ProductCategory>())
            {
                context.DataArray.Add(product);
                context.SaveChangesAsync();
            }
        }
        public virtual List<ProductCategory> Read()
        {
            using (context = new WebSiteContext<ProductCategory>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(ProductCategory product) 
        {
            using(context = new WebSiteContext<ProductCategory>())
            {
                context.DataArray.Update(product);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(ProductCategory product)
        {
            using(context = new WebSiteContext<ProductCategory>())
            {
                context.DataArray.Remove(product);
                context.SaveChangesAsync();
            }
        }
    }
}
