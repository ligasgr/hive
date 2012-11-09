using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Model.Domain;

namespace Hive.Core.Login
{
    public interface LoginService
    {
        User authenticate(User user);
    }
}
