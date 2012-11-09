using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Hive.Domain;

namespace Hive.ServiceLibrary
{
    [ServiceContract]
    public interface HiveService
    {
        [OperationContract]
        User authenticate(User user);
    }
}
