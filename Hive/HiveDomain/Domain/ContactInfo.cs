using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Hive.Domain
{
    [DataContract]
    public class ContactInfo
    {
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
