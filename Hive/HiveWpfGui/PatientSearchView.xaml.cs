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
using Hive.Presenter.ServiceClient;
using Hive.Domain;
using Hive.Presenter.PresenterInterface;
using Hive.Presenter.Presenter;

namespace Hive.WpfGui
{
    /// <summary>
    /// Interaction logic for PatientSearchView.xaml
    /// </summary>
    public partial class PatientSearchView : Window, Hive.Presenter.ViewInterface.PatientSearchView
    {

        private IList<Patient> patientSearchList;
        private PatientSearchPresenter presenter;

        public PatientSearchView()
        {
            InitializeComponent();
            presenter = new PatientSearchPresenterWs(this, Properties.Settings.Default.WebServiceUrl);
            if (PrepareView != null) PrepareView();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (PatientSearchResult != null) PatientSearchResult();   
        }

        public string ErrorMessage
        {
            set { throw new NotImplementedException(); }
        }

        public string ErrorDetails
        {
            set { throw new NotImplementedException(); }
        }

        public string FirstNameFilter
        {
            get { return firstNameField.Text; }
        }

        public string LastNameFilter
        {
            get { return lastNameField.Text; }
        }

        public string PeselFilter
        {
            get { return peselField.Text; }
        }

        public event Presenter.ViewInterface.VoidEventHandler PatientSearchResult;


        public event Presenter.ViewInterface.VoidEventHandler PrepareView;


        public IList<Patient> PatientSearchResultsList
        {
            get
            {
                return patientSearchList;
            }
            set
            {
                this.patientSearchList = value;
                CollectionViewSource patientsDataView = (CollectionViewSource)FindResource("patientsDataView");
                patientsDataView.Source = patientSearchList;
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void viewPatientButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedPatient = PatientList.SelectedItem;
            if (selectedPatient != null)
                new PatientDetailsView(((Patient)selectedPatient).Id).ShowDialog();
        }

        private void deletePatientButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
