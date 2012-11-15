using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Hive.Presenter.PresenterInterface;
using Hive.Presenter.Presenter;

namespace Hive.WpfGui
{
    /// <summary>
    /// Interaction logic for PatientDetailsView.xaml
    /// </summary>
    public partial class PatientDetailsView : Window, Hive.Presenter.ViewInterface.PatientDetailsView
    {
        private long patientId;
        private Domain.Patient patient;
        private PatientDetailsPresenter presenter;

        public PatientDetailsView(long patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.presenter = new PatientDetailsPresenterWs(this, Properties.Settings.Default.WebServiceUrl);
            if (PrepareView != null) PrepareView();
        }

        public long PatientId
        {
            get { return patientId; }
        }

        public Domain.Patient Patient
        {
            set
            {
                patient = value;
                DataContext = patient;
            }
        }


        public event Presenter.ViewInterface.VoidEventHandler PrepareView;
    }
}
