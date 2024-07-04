using Microsoft.EntityFrameworkCore;
using ShopModels.Models;

namespace ShopPages.Components.Models
{
    [PrimaryKey(nameof(RoleID))]
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public List<UserData> userDatas { get; set; }
        public Role()
        {
            RoleID = 1;
            RoleName = "";
        }
    }
    public enum RoleName
    {
        User=1,
        Admin=2,
        SuperAdmin=3
    }
}
