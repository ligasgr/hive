using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Hive.Model.Repository;
using Hive.Model.Domain;
using Hive.Core.Login;

namespace Hive.ServiceLibrary
{
    public class HiveCoreBasedService : HiveService, LoginService
    {
        public User authenticate(User user)
        {
            return new EFAuthenticationService().authenticate(user);
        }
    }
}
