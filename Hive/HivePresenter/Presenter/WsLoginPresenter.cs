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
    public class WsLoginPresenter : LoginPresenter
    {
        private LoginView view;
        private string wsAddress;

        public WsLoginPresenter(LoginView view, string wsAddress)
        {
            this.view = view;
            this.wsAddress = wsAddress;
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
                new ServiceClient.HiveServiceClient("WSHttpBinding_HiveService", wsAddress).authenticate(user);
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
