using Microsoft.EntityFrameworkCore;
using ShopPages.Components.Pages;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ShopModels.Models
{
    [PrimaryKey(nameof(CompanyID))]
    public class Company
    {
        int CompanyID { get; set; }
        string CompanyName { get; set; }
        public Company()
        {
            CompanyName = "";
        }
        public Company(IDataReader reader)
        {
            CompanyID = int.Parse(reader["CompanyID"].ToString());
            CompanyName = reader["CompanyName"].ToString();
        }
    }
}
