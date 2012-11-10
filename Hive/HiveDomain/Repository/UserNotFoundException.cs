using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Repository
{
    public class UserNotFoundException: Exception
    {
        public UserNotFoundException(string login, Exception source):
            base(string.Format("User with login {0} was not found", login), source)
        {
        }
    }
}
