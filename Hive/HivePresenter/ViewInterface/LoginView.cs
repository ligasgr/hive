using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Presenter.ViewInterface
{
    interface LoginView : View
    {
        string Login { get; }
        string Password { get; }
        
        event VoidEventHandler LoginResult;
    }
}
