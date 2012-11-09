using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Hive.Repository;
using Hive.Domain;
using Hive.Login;

namespace Hive.ServiceLibrary
{
    public class HiveCoreBasedService : HiveService, AuthenticationService
    {
        public User authenticate(User user)
        {
            return new EFAuthenticationService().authenticate(user);
        }
    }
}
