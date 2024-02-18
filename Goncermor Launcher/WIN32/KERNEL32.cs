using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Goncermor_Launcher.MainWindow;

namespace Goncermor_Launcher.WIN32
{
    class KERNEL32
    {
        [DllImport("kernel32.dll")]
        public static extern int AllocConsole();
    }
}
