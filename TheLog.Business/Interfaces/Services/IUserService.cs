using System.Collections.Generic;
using TheLog.Business.Entities;

namespace TheLog.Business.Interfaces.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
    }
}
