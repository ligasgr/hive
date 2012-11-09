using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Domain;

namespace Hive.Login
{
    public interface AuthenticationService
    {
        User authenticate(User user);
    }
}
