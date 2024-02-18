using Goncermor_Launcher.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Goncermor_Launcher.WIN32.DWM_API;

namespace Goncermor_Launcher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IntPtr hWnd = new WindowInteropHelper(GetWindow(this)).EnsureHandle();
            DWM_WINDOW_CORNER_PREFERENCE Pref = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUNDSMALL;
            WIN32.DWM_API.DwmSetWindowAttribute(hWnd, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref Pref, sizeof(uint));

        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            _ = AsyncTsk();
        }

        private async Task AsyncTsk() {
            await Task.Delay(2000);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _ = Minecraft.Launch();
        }
    }
}
