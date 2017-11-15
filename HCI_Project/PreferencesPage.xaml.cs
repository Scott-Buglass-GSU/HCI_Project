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

namespace HCI_Project
{
    /// <summary>
    /// Interaction logic for PreferencesPage.xaml
    /// </summary>
    public partial class PreferencesPage : Page
    {
        Frame main;
        public PreferencesPage(Frame mainFrame)
        {
            main = mainFrame;
            InitializeComponent();
        }

        private void btnBack_Button_Click(object sender, RoutedEventArgs e)
        {
            main.GoBack();
        }

        private void btnNotifications_Click(object sender, RoutedEventArgs e)
        {
            if(btnNotifications.Content.ToString() == "ON")
            {
                btnNotifications.Content = "OFF";
            }
            else
            {
                btnNotifications.Content = "ON";
            }
        }
    }
}
