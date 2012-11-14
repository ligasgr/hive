using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Presenter.PresenterInterface;
using Hive.Presenter.ViewInterface;
using Hive.Presenter.ServiceClient;
using Hive.Domain;

namespace Hive.Presenter.Presenter
{
    public class PatientSearchPresenterWs : PatientSearchPresenter
    {
        PatientSearchView view;
        private string wsAddress;

        public PatientSearchPresenterWs(PatientSearchView view, string wsAddress)
        {
            this.view = view;
            this.wsAddress = wsAddress;
            this.view.PrepareView += view_PrepareView;
            this.view.PatientSearchResult += view_PatientSearchResult;
        }

        public void view_PatientSearchResult()
        {
            using (HiveServiceClient service = new HiveServiceClient())
            {
                if (view.FirstNameFilter.Equals(string.Empty)
                    && view.LastNameFilter.Equals(string.Empty)
                    && view.PeselFilter.Equals(string.Empty))
                {
                    view.PatientSearchResultsList = service.FindAllPatiens();
                }
                else
                {
                    Dictionary<string, object> fields = new Dictionary<string, object>();
                    if (!view.FirstNameFilter.Equals(string.Empty))
                        fields.Add("FirstName", view.FirstNameFilter);
                    if (!view.LastNameFilter.Equals(string.Empty))
                        fields.Add("LastName", view.LastNameFilter);
                    if (!view.PeselFilter.Equals(string.Empty))
                        fields.Add("Pesel", view.PeselFilter);
                    view.PatientSearchResultsList = service.FindPatients(fields);
                }
            }
        }

        private void view_PrepareView() { }
    }
}
