using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Presenter.ViewInterface
{
    public delegate void VoidEventHandler();

    public interface View
    {
        void Show();
        void Close();
        event VoidEventHandler PrepareView;
    }
}
