using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Hive.Domain
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string HouseNo { get; set; }
        [DataMember]
        public string FlatNo { get; set; }
    }
}
