using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Presenter.ViewInterface
{
    public interface PatientDetailsView: View
    {
        long PatientId { get; }

        Domain.Patient Patient { set; }
    }
}
