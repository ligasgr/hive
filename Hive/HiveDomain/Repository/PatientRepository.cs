using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Domain;

namespace Hive.Repository
{
    public interface PatientRepository
    {
        IEnumerable<Patient> FindAll();

        IEnumerable<Patient> FindFiltered(Filter filter);
    }
}
