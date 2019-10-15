using HR.Themes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HR.Themes.WPF
{
    public class WindowControl: Window, IWindow
    {
        void IWindow.Show()
        {
            base.Show();
            base.Activate();
        }
    }
}
