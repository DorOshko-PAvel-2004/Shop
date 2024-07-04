using ShopModels.Controllers.DBConnection;
using ShopModels.Models;
namespace ShopModels.Controllers.Service
{
    public class UserDataService
    {
        dbUserData _dbuserData;
        List<UserData> UserDatas;
        public UserDataService()
        {
            _dbuserData = new dbUserData();
        }
        public virtual void Create(UserData UserData)
        {
            _dbuserData.Create(UserData);
        }
       public virtual List<UserData> Read()
       {
            UserDatas = _dbuserData.Read();
            return UserDatas;
       }
       public virtual void Update(UserData UserData) 
       {
            _dbuserData.Update(UserData);
       }
       public virtual void Delete(UserData UserData)
       {
            _dbuserData.Delete(UserData);
       }
        public UserData Select(string login)
        {
            UserData user = _dbuserData.Select(login);
            if(user.Login==login)
            {
                return user;
            }
            else { return null; }
        }
    }
}
