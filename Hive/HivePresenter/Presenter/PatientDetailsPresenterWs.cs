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
    public class PatientDetailsPresenterWs: PatientDetailsPresenter
    {
        private PatientDetailsView view;
        private string wsAddress;

        public PatientDetailsPresenterWs(PatientDetailsView view, string wsAddress)
        {
            this.view = view;
            this.wsAddress = wsAddress;
            this.view.PrepareView += view_PrepareView;
        }

        private void view_PrepareView()
        {
            using (HiveServiceClient service = new HiveServiceClient())
            {
                Patient result = service.FindPatientById(view.PatientId);
                view.Patient = result;
            }
        }
    }
}
