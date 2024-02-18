using CmlLib.Core;
using CmlLib.Core.Auth;
using System;
using System.Threading.Tasks;

namespace Goncermor_Launcher.Helpers
{
    class Minecraft
    {

        public static string? UserName { get; set; } = "Goncermor";

        public static async Task Launch()
        {
            var path = new MinecraftPath();

            var launcher = new CMLauncher(path);

            launcher.LogOutput += Launcher_LogOutput;
            launcher.ProgressChanged += Launcher_ProgressChanged;
            launcher.FileChanged += Launcher_FileChanged;


            var process = await launcher.CreateProcessAsync("1.19.2", new MLaunchOption
            {
                MaximumRamMb = 2048,
                Session = MSession.CreateOfflineSession(UserName!),
                FullScreen = false
            });
            process.Start();
            while (process.MainWindowHandle == IntPtr.Zero);
            while (!process.HasExited)
            {
                await Task.Delay(1000);
                WIN32.USER32.SetWindowText(process.MainWindowHandle, "Goncermor MC Server 1.19.2");
            }
            


        }

        private static void Launcher_FileChanged(CmlLib.Core.Downloader.DownloadFileChangedEventArgs e)
        {
            Console.WriteLine("File: " + e.FileName);
        }

        private static void Launcher_ProgressChanged(object? sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Console.WriteLine("PG: " +e.ProgressPercentage);
        }

        private static void Launcher_LogOutput(object? sender, string e)
        {
            Console.WriteLine(e);
        }

        public void Kill()
        {

        }

    }
}
