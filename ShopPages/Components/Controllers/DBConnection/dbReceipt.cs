using ShopModels.Models;

namespace ShopModels.Controllers.DBConnection
{
    public class dbReceipt : CRUD<Receipt>
    {
        public WebSiteContext<Receipt> context { get; set; }
        public virtual void Create(Receipt data)
        {
            using (context = new WebSiteContext<Receipt>())
            {
                context.DataArray.Add(data);
                context.SaveChangesAsync();
            }
        }
        public virtual List<Receipt> Read()
        {
            using (context = new WebSiteContext<Receipt>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(Receipt data) 
        {
            using(context = new WebSiteContext<Receipt>())
            {
                context.DataArray.Update(data);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(Receipt data)
        {
            using(context = new WebSiteContext<Receipt>())
            {
                context.DataArray.Remove(data);
                context.SaveChangesAsync();
            }
        }
    }
}
