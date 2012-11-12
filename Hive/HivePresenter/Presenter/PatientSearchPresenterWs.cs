using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Presenter.PresenterInterface;
using Hive.Presenter.ViewInterface;
using Hive.Presenter.ServiceClient;

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
                view.PatientSearchResultsList = service.FindAllPatiens();
            }
        }

        private void view_PrepareView() { }
    }
}
