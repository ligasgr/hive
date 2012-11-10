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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hive.Login;
using Hive.Domain;
using Hive.ServiceLibrary;
using Hive.Presenter.ViewInterface;
using Hive.Presenter.Presenter;

namespace Hive.WpfGui
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window, Hive.Presenter.ViewInterface.LoginView
    {
        private Hive.Presenter.PresenterInterface.LoginPresenter loginPresenter;
        private string errorMessage;
        private string errorDetails;

        public LoginView()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter(this);
            if (PrepareView != null) PrepareView();
        }

        private void logInButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginResult != null) LoginResult();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public string Login
        {
            get { return loginField.Text; }
        }

        public string Password
        {
            get { return passwordField.Password; }
        }

        public Presenter.ViewInterface.View successView
        {
            get { return new StartupView(); }
        }

        public event Presenter.ViewInterface.VoidEventHandler LoginResult;

        public event Presenter.ViewInterface.VoidEventHandler PrepareView;

        public string ErrorMessage
        {
            set
            {
                errorMessage = value;
                statusBar.Text = errorMessage;
            }
        }

        public string ErrorDetails
        {
            set
            {
                errorDetails = value;
                statusBar.ToolTip = errorDetails;
            }
        }
    }
}
