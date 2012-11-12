using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using Hive.Domain;
using Hive.ServiceLibrary;

namespace Hive.ServiceLibrary.Contract
{
    [MessageContract(WrapperNamespace = ServiceConstants.Namespace)]
    public class FindPatientsResponse
    {
        [MessageBodyMember]
        public IEnumerable<Patient> Results { get; set; }
    }
}
