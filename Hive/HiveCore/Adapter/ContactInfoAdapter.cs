using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Adapter
{
    public class ContactInfoAdapter
    {
        public static Domain.ContactInfo fromModel(Model.Patient p)
        {
            Domain.ContactInfo result = new Domain.ContactInfo();
            result.Phone = p.Phone;
            result.Mobile = p.Mobile;
            result.Email = p.Email;
            return result;
        }
    }
}
