using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopModels.Controllers.DBConnection;
using ShopModels.Controllers.Service;
using ShopModels.Models;
using ShopPages;
using ShopPages.Components.Models;
using ShopPages.Components.Pages;

namespace ShopModels.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class Unknown : ControllerBase
    {
        // GET: api/<User>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            ProductService service = new ProductService();
            return service.Read();
        }
        [HttpPost]
        public string Regist()
        {
            //if (HttpContext.Session.GetString("user") != null)
            //{
            //    Redirect("/Products"); //return RedirectToActionPermanent("Index");//////////////////////////////////////////////////
            //}
            dbUserData dbUser = new dbUserData();
            UserData _user = new UserData();
            string Name = Registration.login;
            string Password = Registration.password;
            if (!Security.StringCheck(new string[] { Name, Password }))
            {
                Registration.Registration_Message = "You can use only letters and numbers.";
                return "Error";
            }
            _user.Login = Name;
            List<UserData> users = dbUser.Read();
            if (users.Where(x=>x.Login==Name).Count()!=0)
            {
                Registration.Registration_Message = "This name is already used.";
                return "Error";
            }
            _user.Password = Password;
            dbUser.Create(_user);
            Registration.Registration_Message = "";
            return "/Products";///////////////////////////////////

        }

        [HttpPost]
        public string Authorization(UserData user)
        {
            if (Is_Authorizated())
            {
                ShopPages.Components.Pages.Authorization.Registration_Message = "You're already an authorizated user.";
                return "Home";
            }
            if (!Security.StringCheck(new string[] { user.Login, user.Password }))
            {
                ShopPages.Components.Pages.Authorization.Registration_Message = "You can use only letters and numbers.";
                return "Error";
            }
            UserData? AcceptUser = new UserDataService().Select(user.Login);
            if(AcceptUser==null || AcceptUser.Password!=user.Password)
            {
                ShopPages.Components.Pages.Authorization.Registration_Message = "User not found or incorrect password.";
                return "Error";
            }
            switch (AcceptUser.RoleID)
            {
                case (int)RoleName.User:
                    StaticHttpContext.Current.Session.SetString("user", user.Login);
                    return "User";
                case (int)RoleName.Admin:
                    StaticHttpContext.Current.Session.SetString("admin", user.Login);
                    return "Admin";
                case (int)RoleName.SuperAdmin:
                    StaticHttpContext.Current.Session.SetString("superadmin", user.Login);
                    return "SuperAdmin";
                default: return "Error";

            }
        }
        public bool Is_Authorizated()
        {
            if(StaticHttpContext.Current.Session.GetString("user") != null ||
                StaticHttpContext.Current.Session.GetString("admin") != null ||
                StaticHttpContext.Current.Session.GetString("superadmin") != null)
            { return true; }
            else { return false; }
        }

    }
}
