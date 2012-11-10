using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hive.Presenter.ViewInterface
{
    public enum ViewMode
    {
        EditMode = 0,
        AddMode = 1
    }

    public interface EditableView: View
    {
        ViewMode Mode { get; set; }
        void SetModeDependentSettings();
    }
}
