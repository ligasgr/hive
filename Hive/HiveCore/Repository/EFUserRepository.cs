using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Model;

namespace Hive.Repository
{
    public class EFUserRepository : UserRepository
    {

        private HiveEntities db = new HiveEntities();

        public Hive.Domain.User Find(string login)
        {
            try
            {
                var result = from u in db.Users where u.Login == login select u;
                User record = result.Single();
                return new Hive.Domain.User(record.Login, record.Password);
            }
            catch (Exception ex)
            {
                throw new UserNotFoundException(login, ex);
            }
        }
    }
}
