using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Hive.Domain
{
    [DataContract]
    public class Patient
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Pesel { get; set; }
        [DataMember]
        public string IdDocument { get; set; }
        [DataMember]
        public string BirthPlace { get; set; }
        [DataMember]
        public DateTime? BirthDate { get; set; }
        [DataMember]
        public Address Address { get; set; }
        [DataMember]
        public ContactInfo ContactInfo { get; set; }
        [DataMember]
        public IList<Advice> Advices { get; set; }
    }
}
