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
    public class LocalLoginPresenter: DefaultLoginPresenter
    {
        public LocalLoginPresenter(LoginView view) : base(view)
        {
        }

        protected override AuthenticationService getAuthenticationService()
        {
            return new AuthenticationServiceImpl();
        }
    }
}
