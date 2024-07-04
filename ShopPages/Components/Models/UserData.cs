using Microsoft.EntityFrameworkCore;
using ShopPages.Components.Models;
using ShopPages.Components.Pages;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ShopModels.Models
{

    [PrimaryKey(nameof(Login))]
    public class UserData
    {
        public string Login { get; set; }
        public string Password { get; set; }
        [ForeignKey("Role")]
        public int RoleID { get; set; }
        public Role Role;
        public UserData() 
        {
            Login = "";
            Password = "";
            RoleID = 1;
        }
        public UserData(IDataReader reader)
        {
            Login = reader["Login"].ToString() == "" ? string.Empty : reader["Login"].ToString();
            Password = reader["Password"].ToString()== "" ? string.Empty : reader["Password"].ToString();
            RoleID = reader["RoleID"].ToString() == "0" ? 0 : int.Parse(reader["RoleID"].ToString());
        }
    }
}
