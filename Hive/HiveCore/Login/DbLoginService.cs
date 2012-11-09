using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Model.Domain;
using Hive.Model.Repository;

namespace Hive.Core.Login
{
    public class DbLoginService : LoginService
    {
        private UserRepository repo = new EFUserRepository();

        public Hive.Model.Domain.User authenticate(Hive.Model.Domain.User user)
        {
            User userFromDb = repo.Find(user.Login);
            if (!userFromDb.Password.Equals(user.Password))
                throw new Exception("Authentication failed!");
            else
                return userFromDb;
        }
    }
}
