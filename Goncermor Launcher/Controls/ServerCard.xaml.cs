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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Goncermor_Launcher.Controls
{
    public partial class ServerCard : UserControl
    {
        public ServerCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Icon { get; set; } = "Memory";
        public string ValueName { get; set; } = "Name";
        public string Value { get; set; } = "NaN";
        public string? SecondValue { get; set; }

        private bool SecondValueSet = false;

        private void ValueElement_Loaded(object sender, RoutedEventArgs e)
        {
            if (SecondValue != null && !SecondValueSet)
            {
                SecondValueSet = true;
                ValueElement.Inlines.Add(new LineBreak());
                ValueElement.Inlines.Add(new Run { Text = $"{SecondValue}", FontSize = 12 });
            }
        }
    }
}
