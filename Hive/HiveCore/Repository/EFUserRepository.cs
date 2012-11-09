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

        public Hive.Model.Domain.User Find(string login)
        {
            var result = from u in db.Users where u.Login == login select u;
            Hive.Model.User record = result.Single();
            return new Hive.Model.Domain.User(record.Login, record.Password);
        }
    }
}
