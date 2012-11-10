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
    public class WsLoginPresenter : DefaultLoginPresenter
    {
        private string wsAddress;

        public WsLoginPresenter(LoginView view, string wsAddress): base (view)
        {
            this.wsAddress = wsAddress;
        }
        
        protected override AuthenticationService getAuthenticationService()
        {
            return new WsBasedAuthenticationService(wsAddress);
        }
    }

    class WsBasedAuthenticationService : AuthenticationService
    {
        private string wsAddress;

        public WsBasedAuthenticationService(string wsAddress)
        {
            this.wsAddress = wsAddress;
        }

        public User authenticate(User user)
        {
            return new ServiceClient.HiveServiceClient("WSHttpBinding_HiveService", wsAddress).authenticate(user);
        }
    }
}
