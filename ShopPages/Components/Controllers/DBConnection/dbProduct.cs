using ShopModels.Models;
namespace ShopModels.Controllers.DBConnection
{
    public class dbProduct:CRUD<Product>
    {
        public WebSiteContext<Product> context { get; set; }
        public virtual void Create(Product product)
        {
            using (context = new WebSiteContext<Product>())
            {
                context.DataArray.Add(product);
                context.SaveChangesAsync();
            }
        }
        public virtual List<Product> Read()
        {
            using (context = new WebSiteContext<Product>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(Product product) 
        {
            using(context = new WebSiteContext<Product>())
            {
                context.DataArray.Update(product);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(Product product)
        {
            using(context = new WebSiteContext<Product>())
            {
                context.DataArray.Remove(product);
                context.SaveChangesAsync();
            }
        }
    }
}
