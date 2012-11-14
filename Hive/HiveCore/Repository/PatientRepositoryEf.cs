using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Model;
using System.Data.Objects;

namespace Hive.Repository
{
    public class PatientRepositoryEf: PatientRepository
    {
        public IEnumerable<Domain.Patient> FindAll()
        {
            LinkedList<Domain.Patient> patientList = new LinkedList<Domain.Patient>();
            using (HiveEntities db = new HiveEntities())
            {
                var results = from p in db.Patients orderby p.Id select p;
                foreach (Patient p in results.ToList())
                {
                    patientList.AddLast(fromModel(p));
                }
            }
            return patientList;
        }

        public IEnumerable<Domain.Patient> FindFiltered(Domain.Filter filter)
        {
            LinkedList<Domain.Patient> patientList = new LinkedList<Domain.Patient>();
            using (HiveEntities db = new HiveEntities())
            {
                string query = filter.ToQuery("it", "and");
                if (!query.Equals(string.Empty))
                {
                    var results = db.Patients.Where(query);
                    foreach (Patient p in results.ToList())
                    {
                        patientList.AddLast(fromModel(p));
                    }
                }
                else
                {
                    return FindAll();
                }
            }
            return patientList;
        }

        private static Domain.Patient fromModel(Patient p)
        {
            Domain.Patient result = new Domain.Patient();
            result.Id = p.Id;
            result.FirstName = p.FirstName;
            result.LastName = p.LastName;
            result.Pesel = p.Pesel;
            result.BirthDate = p.BirthDate;

            return result;
        }
    }
}
