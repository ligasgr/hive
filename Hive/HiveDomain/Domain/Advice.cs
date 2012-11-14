using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Hive.Domain
{
    [DataContract]
    public class Advice
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public DateTime VisitDate { get; set; }
        [DataMember]
        public String Symptoms { get; set; }
        [DataMember]
        public String Description { get; set; }
    }
}
