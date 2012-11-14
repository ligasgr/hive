using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Repository
{
    public class PatientNotFoundException : Exception
    {
        public PatientNotFoundException(Int64 id, Exception source) :
            base(string.Format("Patient with id {0} was not found", id), source)
        {
        }
    }
}
