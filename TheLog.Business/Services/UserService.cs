using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TheLog.Business.Context;
using TheLog.Business.Entities;
using TheLog.Business.Interfaces.Services;

namespace TheLog.Business.Services
{
    public class UserService : IUserService
    {

        private readonly UserDbContext _datacontext;
        private readonly ILogger _logger;

        public UserService(UserDbContext datacontext, ILogger<UserService> logger)
        {
            _datacontext = datacontext;
            _logger = logger;
        }
        public IEnumerable<User> GetAllUsers()
        {
            var userCollection = _datacontext.Users;
            _logger.LogInformation("Logger: getallusers");
            Trace.WriteLine("Trace: getallusers");
            Trace.Flush();
            Debug.WriteLineIf(userCollection.ToList().Count > 0, "This list has something.");
            return userCollection;
        }

        public User GetUserById(int id)
        {
            var theUser = _datacontext.Users.Find(id);
            _logger.LogInformation("Logger: getuserbyid");
            Trace.WriteLine("Trace: getuserbyid");
            Trace.Flush();
            Debug.WriteLineIf(theUser == null, "Whoa hold up! this user does not exist!");
            return theUser;
        }
    }
}
