using ShopModels.Models;
namespace ShopModels.Controllers.DBConnection
{
    public class dbCompany:CRUD<Company>
    {
        public WebSiteContext<Company> context { get; set; }
        public virtual void Create(Company data)
        {
            using (context = new WebSiteContext<Company>())
            {
                context.DataArray.Add(data);
                context.SaveChangesAsync();
            }
        }
        public virtual List<Company> Read()
        {
            using (context = new WebSiteContext<Company>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(Company data) 
        {
            using(context = new WebSiteContext<Company>())
            {
                context.DataArray.Update(data); ;
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(Company data)
        {
            using(context = new WebSiteContext<Company>())
            {
                context.DataArray.Remove(data); ;
                context.SaveChangesAsync();
            }
        }
    }
}
