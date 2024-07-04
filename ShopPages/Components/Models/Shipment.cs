using Microsoft.EntityFrameworkCore;
using ShopPages.Components.Pages;
using System.Data;
namespace ShopModels.Models
{
    [PrimaryKey(nameof(ShipmentID))]
    public class Shipment
    {
        int ShipmentID { get; set; }
        DateTime StartDate = DateTime.MinValue;
        DateTime EndDate = DateTime.MinValue;
        public Shipment()
        {

        }
        public Shipment(IDataReader reader)
        {
            ShipmentID = int.Parse(reader["ShipmentID"].ToString());
            DateTime.TryParse(reader["StartDate"].ToString(), out StartDate);
            DateTime.TryParse(reader["StartDate"].ToString(), out EndDate);
        }
    }
}
