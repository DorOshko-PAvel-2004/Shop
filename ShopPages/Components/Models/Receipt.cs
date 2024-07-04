using Microsoft.EntityFrameworkCore;
using ShopPages.Components.Pages;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ShopModels.Models
{
    [PrimaryKey(nameof(ReceiptID),nameof(Login))]
    public class Receipt
    {
        int ReceiptID { get; set; }
        [ForeignKey("UserData")]
        string Login { get; set; }
        int TotalAmount { get; set; }

        public Receipt()
        {

        }
        public Receipt(IDataReader reader)
        {
            ReceiptID = int.Parse(reader["ReceiptID"].ToString());
            Login = reader["Login"].ToString();
            TotalAmount = int.TryParse(reader["TotalAmount"].ToString(), out int a) 
                ? int.Parse(reader["TotalAmount"].ToString()) : 0;
        }
    }
}
