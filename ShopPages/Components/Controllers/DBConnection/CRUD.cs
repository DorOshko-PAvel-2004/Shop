using ShopModels.Models;

namespace ShopModels.Controllers.DBConnection
{
    public interface CRUD<T> where T:class
    {
        protected WebSiteContext<T> context { get; set; }
        public virtual void Create(T Data)
        {
            using (context = new WebSiteContext<T>())
            {
                context.DataArray.Add(Data);
                context.SaveChangesAsync();
            }
        }
        public virtual List<T> Read()
        {
            using (context = new WebSiteContext<T>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(T Data)
        {
            using (context = new WebSiteContext<T>())
            {
                context.DataArray.Update(Data);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(T Data)
        {
            using (context = new WebSiteContext<T>())
            {
                context.DataArray.Remove(Data);
                context.SaveChangesAsync();
            }
        }
    }
}
