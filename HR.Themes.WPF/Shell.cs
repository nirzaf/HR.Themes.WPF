using HR.Themes.Core;
using HR.Themes.Prototype.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace HR.Themes.WPF
{
    public class Shell : IShell
    {
        public bool IsLightVersion { get { return false; } }

        public void ExitApplication()
        {
            App.Current.Shutdown();
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        public IWindow CreateWindow(object userControl, string title)
        {
            var window = new WindowControl();
            var child = (UserControl)userControl;
            window.Content = child;
            window.Title = title;
            window.SizeToContent = SizeToContent.WidthAndHeight;
            window.Show();

            return window;
        }
    }
}
