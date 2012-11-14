using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Model;

namespace Hive.Adapter
{
    public class PatientAdapter
    {
        public static Domain.Patient fromModel(Patient p, bool fullInfo)
        {
            Domain.Patient result = new Domain.Patient();
            result.Id = p.Id;
            result.FirstName = p.FirstName;
            result.LastName = p.LastName;
            result.Pesel = p.Pesel;
            result.BirthDate = p.BirthDate;
            result.BirthPlace = p.BirthPlace;
            result.IdDocument = p.IdDocument;

            if (fullInfo)
            {
                result.Address = AddressAdapter.fromModel(p);
                result.ContactInfo = ContactInfoAdapter.fromModel(p);
                result.Advices = AdviceAdapter.fromModel(p);
            }
            return result;
        }
    }
}
