using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Goncermor_Launcher.MainWindow;

namespace Goncermor_Launcher.WIN32
{
    class USER32
    {
        [DllImport("user32.dll")]
        public static extern int SetWindowText(IntPtr hWnd, string text);
    }
}
