using System.Collections.Generic;
using XUnitIntegrationTest.WebApplication.Models;

namespace XUnitIntegrationTest.WebApplication.Data
{
    public static class UserDataSource
    {
        public static List<UserModel> Users
        {
            get
            {
                return new List<UserModel>
                {
                    new UserModel
                    {
                        Id = 1,
                        Name = "Farhad"
                    },
                    new UserModel
                    {
                        Id  = 2,
                        Name = "Himan"
                    },
                    new UserModel
                    {
                        Id  = 2,
                        Name = "Moji"
                    }
                };
            }
        }
    }
}
