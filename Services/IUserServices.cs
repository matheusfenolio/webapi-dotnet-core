using webapi_dotnet_core.Models;
using System.Collections.Generic;

namespace webapi_dotnet_core.Services
{
    public interface IUserServices
    {
        User AddUser(User users);
        Dictionary<string, User> GetUser();
    }
}