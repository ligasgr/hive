using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Presenter.ViewInterface
{
    public interface LoginView : View
    {
        string Login { get; }
        string Password { get; }
        View successView { get; }
        string ErrorMessage { set; }
        string ErrorDetails { set; }
        
        event VoidEventHandler LoginResult;
    }
}
