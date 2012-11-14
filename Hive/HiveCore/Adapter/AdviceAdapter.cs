using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Model;

namespace Hive.Adapter
{
    public class AdviceAdapter
    {
        public static IList<Domain.Advice> fromModel(Model.Patient p)
        {
            IList<Domain.Advice> result = new List<Domain.Advice>();
            foreach (Advice a in p.Advices)
            {
                result.Add(AdviceAdapter.fromModel(a));
            }
            return result;
        }

        public static Domain.Advice fromModel(Advice a)
        {
            Domain.Advice result = new Domain.Advice();
            result.Id = a.Id;
            result.Symptoms = a.Symptoms;
            result.Description = a.Description;
            result.VisitDate = a.VisitDate;

            return result;
        }
    }
}
