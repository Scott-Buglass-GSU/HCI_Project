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
    /// Interaction logic for SleepUpdate.xaml
    /// </summary>
    public partial class SleepUpdate : Page
    {
        Popup parent; //store a reference to the popup containing this window
        MainWindow window; //store a reference to the main window
        int max = 15;
        int min = 0;
        int start = 0;
        int hours = 0;

        public SleepUpdate(MainWindow mw)
        {
            window = mw;
            parent = mw.popTrackerPop;
            InitializeComponent();
            txtEntry.Text = start.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (hours != 0)
            {
                //re-enables the main for use
                window.frmMain.IsEnabled = true;
                //closes out the popup holding this page
                parent.IsOpen = false;
            }
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (hours != 0)
            {
                //re-enables the main for use
                window.frmMain.IsEnabled = true;
                //closes out the popup holding this page
                parent.IsOpen = false;
            }
        }
        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (txtEntry.Text != "")
                n = Convert.ToInt32(txtEntry.Text);
            else n = 0;
            if (n < max)
                txtEntry.Text = Convert.ToString(n + 1);
            hours = Convert.ToInt32(txtEntry.Text);
        }
        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (txtEntry.Text != "")
                n = Convert.ToInt32(txtEntry.Text);
            else n = 0;
            if (n > min)
                txtEntry.Text = Convert.ToString(n - 1);
            hours = Convert.ToInt32(txtEntry.Text);
        }
    }
}
