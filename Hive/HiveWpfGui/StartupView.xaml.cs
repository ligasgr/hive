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
using Hive.Presenter.ViewInterface;

namespace Hive.WpfGui
{
    /// <summary>
    /// Interaction logic for StartupView.xaml
    /// </summary>
    public partial class StartupView : Window, View
    {
        public StartupView()
        {
            InitializeComponent();
        }

        public event VoidEventHandler PrepareView;

        private void patientsButton_Click(object sender, RoutedEventArgs e)
        {
            var view = new PatientSearchView();
            view.Show();
        }

        private void advicesButton_Click(object sender, RoutedEventArgs e)
        {
            var view = new AdviceSearchView();
            view.Show();
        }
    }
}
