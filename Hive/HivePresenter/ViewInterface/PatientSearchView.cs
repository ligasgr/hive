using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Domain;

namespace Hive.Presenter.ViewInterface
{
    public interface PatientSearchView : View
    {
        string ErrorMessage { set; }
        string ErrorDetails { set; }
        IList<Patient> PatientSearchResultsList { get; set; }

        event VoidEventHandler PatientSearchResult;
    }
}
