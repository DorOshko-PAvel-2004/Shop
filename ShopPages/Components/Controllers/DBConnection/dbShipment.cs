using ShopModels.Models;

namespace ShopModels.Controllers.DBConnection
{
    public class dbShipment : CRUD<Shipment>
    {
        public WebSiteContext<Shipment> context { get; set; }
        public virtual void Create(Shipment data)
        {
            using (context = new WebSiteContext<Shipment>())
            {
                context.DataArray.Add(data);
                context.SaveChangesAsync();
            }
        }
        public virtual List<Shipment> Read()
        {
            using (context = new WebSiteContext<Shipment>())
            {
                return context.DataArray.ToList();
            }
        }
        public virtual void Update(Shipment data) 
        {
            using(context = new WebSiteContext<Shipment>())
            {
                context.DataArray.Update(data);
                context.SaveChangesAsync();
            }
        }
        public virtual void Delete(Shipment data)
        {
            using(context = new WebSiteContext<Shipment>())
            {
                context.DataArray.Remove(data);
                context.SaveChangesAsync();
            }
        }
    }
}
