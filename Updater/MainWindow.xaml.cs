using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Updater
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e) => _ = AsyncTask();

        private async Task AsyncTask()
        {
            Storyboard? Sb_Spin = this.FindResource("Spin") as Storyboard;
            Storyboard? Sb_Show = this.FindResource("Show") as Storyboard;
            Sb_Show?.Begin();
            await Task.Delay(1900);
            Container.Opacity = 1;
            ContainerScale.ScaleX = 1;
            ContainerScale.ScaleY = 1;
            ColorWheelScale.ScaleX = 1;
            ColorWheelScale.ScaleY = 1;
            ColorWheelBlurScale.ScaleX = 1;
            ColorWheelBlurScale.ScaleY = 1;
            Sb_Spin?.Begin();
            
        }
    }
}
