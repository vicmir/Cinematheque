using System.Collections.Generic;
using HelloWebApi.Models;

namespace HelloWebApi.Interfaces.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
    }
}
