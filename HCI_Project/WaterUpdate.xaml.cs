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
using System.Windows.Controls.Primitives;

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for WaterUpdate.xaml
    /// </summary>
    public partial class WaterUpdate : Page
    {
        MainWindow window;
        Popup parent;
        public WaterUpdate(MainWindow mw)
        {
            window = mw;
            parent = mw.popTrackerPop;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //re-enables the main for use
            window.mainFrame.IsEnabled = true;
            //closes out the popup holding this page
            parent.IsOpen = false;
        }
    }
}
