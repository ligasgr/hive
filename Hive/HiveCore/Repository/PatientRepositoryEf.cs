using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Model;
using System.Data.Objects;
using Hive.Adapter;

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
                    patientList.AddLast(PatientAdapter.fromModel(p, false));
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
                        patientList.AddLast(PatientAdapter.fromModel(p, false));
                    }
                }
                else
                {
                    return FindAll();
                }
            }
            return patientList;
        }

        public Domain.Patient Find(long id)
        {
            using (HiveEntities db = new HiveEntities())
            {
                var result = from p in db.Patients
                             where p.Id == id select p;
                Domain.Patient patient = PatientAdapter.fromModel(result.Single(), true);
                return patient;
            }
        }
    }
}
