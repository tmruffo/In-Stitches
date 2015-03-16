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

namespace InStitches
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        enum NeedleType { STANDARD = 0, DOUBLE_POINTED = 1, CIRCULAR = 2 };
        enum HookType { STANDARD = 0, STEEL = 1 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InventoryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content == null)
            {
                ((Button)sender).Content = 1;
            }
            else
            {
                ((Button)sender).Content = Convert.ToInt32(((Button)sender).Content) + 1;
            }
        }
    }
}
