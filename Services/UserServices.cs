using webapi_dotnet_core.Models;
using System.Collections.Generic;

namespace webapi_dotnet_core.Services
{
    public class UserServices : IUserServices
    {
        private readonly Dictionary<string, User> _Users;

        public UserServices()
        {
            _Users = new Dictionary<string, User>();
        }

        public User AddUser(User users)
        {
            _Users.Add(users.name, users);

            return users;
        }

        public Dictionary<string, User> GetUser()
        {
            return _Users;
        }
    }
}