using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Hive.Domain;
using Hive.ServiceLibrary.Contract;

namespace Hive.ServiceLibrary
{
    internal sealed class ServiceConstants
    {
        internal const string Namespace = "http://ligasgr.net/services/hive";
    } 

    [ServiceContract(Namespace=ServiceConstants.Namespace)]
    public interface HiveService
    {
        [OperationContract]
        User Authenticate(User user);

        [OperationContract]
        FindPatientsResponse FindAllPatiens();
    }
}
