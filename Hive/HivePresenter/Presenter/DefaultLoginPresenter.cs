using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hive.Presenter.ViewInterface;
using Hive.Login;
using Hive.Domain;
using Hive.Presenter.PresenterInterface;

namespace Hive.Presenter.Presenter
{
    public class DefaultLoginPresenter : LoginPresenter
    {
        private LoginView view;

        public DefaultLoginPresenter(LoginView view)
        {
            this.view = view;
            this.view.PrepareView += view_PrepareView;
            this.view.LoginResult += view_LoginResult;
        }

        private void view_PrepareView()
        {
        }

        private void view_LoginResult()
        {
            try
            {
                User user = new User(this.view.Login, this.view.Password);
                new EFAuthenticationService().authenticate(user);
                this.view.successView.Show();
                this.view.Close();
            }
            catch (Exception ex)
            {
                this.view.ErrorMessage = ex.Message;
                this.view.ErrorDetails = ex.Message + " \n " + ex.StackTrace;
            }
        }
    }
}
