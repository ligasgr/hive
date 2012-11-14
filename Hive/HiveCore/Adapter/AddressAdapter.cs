using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Adapter
{
    class AddressAdapter
    {
        public static Domain.Address fromModel(Model.Patient p)
        {
            Domain.Address result = new Domain.Address();
            result.City = p.City;
            result.PostalCode = p.PostalCode;
            result.Street = p.Street;
            result.HouseNo = p.HouseNo;
            result.FlatNo = p.FlatNo;
            return result;
        }
    }
}
