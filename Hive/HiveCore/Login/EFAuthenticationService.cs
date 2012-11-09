using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Domain;
using Hive.Repository;

namespace Hive.Login
{
    public class EFAuthenticationService : AuthenticationService
    {
        private UserRepository repo = new EFUserRepository();

        public User authenticate(User user)
        {
            User userFromDb = repo.Find(user.Login);
            if (!userFromDb.Password.Equals(user.Password))
                throw new Exception("Authentication failed!");
            else
                return userFromDb;
        }
    }
}
