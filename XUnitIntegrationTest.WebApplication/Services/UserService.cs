using System.Collections.Generic;
using System.Linq;
using XUnitIntegrationTest.WebApplication.Data;
using XUnitIntegrationTest.WebApplication.Models;

namespace XUnitIntegrationTest.WebApplication.Services
{
    public interface IUserService
    {
        UserModel GetById(int id);
        List<UserModel> GetUsers();
    }

    public class UserService : IUserService
    {
        public List<UserModel> GetUsers()
        {
            return UserDataSource.Users;
        }
        public UserModel GetById(int id)
        {
            var user = UserDataSource.Users
                .Where(a => a.Id == id)
               .FirstOrDefault();

            return user;
        }
    }
}
