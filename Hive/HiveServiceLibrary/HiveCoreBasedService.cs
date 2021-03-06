﻿using System;
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
    [ServiceBehavior(Namespace=ServiceConstants.Namespace)]
    public class HiveCoreBasedService : HiveService, AuthenticationService
    {
        public User Authenticate(User user)
        {
            return new AuthenticationServiceImpl().Authenticate(user);
        }

        public Contract.FindPatientsResponse FindAllPatiens()
        {
            Contract.FindPatientsResponse response = new Contract.FindPatientsResponse();
            response.Results = new PatientRepositoryEf().FindAll();
            return response;
        }


        public Contract.FindPatientsResponse FindPatients(Contract.WsFilter filter)
        {
            Contract.FindPatientsResponse response = new Contract.FindPatientsResponse();
            response.Results = new PatientRepositoryEf().FindFiltered(filter);
            return response;
        }

        public Patient FindPatientById(Int64 patientId)
        {
            Patient response = new PatientRepositoryEf().Find(patientId);
            return response;
        }
    }
}
