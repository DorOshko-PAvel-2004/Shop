using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ShopModels.Models;

namespace ShopModels.Controllers.DBConnection
{
    public class dbUserData:CRUD<UserData>
    {
        WebSiteContext<UserData> _context;
        public WebSiteContext<UserData> context { get; set; }
        public dbUserData() 
        {

        }
        public virtual void Create(UserData userData)
        {
            using (context = new WebSiteContext<UserData>())
            {
                context.DataArray.Add(userData); 
                context.SaveChangesAsync();
            }
        }
        public virtual List<UserData> Read()
        {
            using (context = new WebSiteContext<UserData>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(UserData userData) 
        {
            using(context = new WebSiteContext<UserData>())
            {
                context.DataArray.Update(userData);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(UserData userData)
        {
            using(context = new WebSiteContext<UserData>())
            {
                context.DataArray.Remove(userData);
                context.SaveChangesAsync();
            }
        }
        public UserData Select(string login)
        {

            using (context = new WebSiteContext<UserData>())
            {
                return context.DataArray.FromSqlRaw("select * from dbo.UserData where UserData.Login={0}",login)?.FirstOrDefault();
            }
        }
    }
}
