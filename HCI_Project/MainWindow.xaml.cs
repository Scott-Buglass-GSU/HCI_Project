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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] TrackerButtons;

        public MainWindow()
        {
            InitializeComponent();
            TrackerButtons = new Button[8];
            TrackerButtons[0] = btnTracker0;
            TrackerButtons[1] = btnTracker1;
            TrackerButtons[2] = btnTracker2;
            TrackerButtons[3] = btnTracker3;
            TrackerButtons[4] = btnTracker4;
            TrackerButtons[5] = btnTracker5;
            TrackerButtons[6] = btnTracker6;
            TrackerButtons[7] = btnTracker7;
        }

        private void btnPreferences_Click(object sender, RoutedEventArgs e)
        {
            PreferencesPage preferences = new PreferencesPage(mainFrame);
            mainFrame.Navigate(preferences);
        }

        private void mainFrame_ContentRendered(object sender, EventArgs e)
        {
            mainFrame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
        }

        private void btnTracker_Click(object sender, RoutedEventArgs e)
        {
            //pull button and grid from form
            Button button = sender as Button;
            Frame frm = popTrackerPop.Child as Frame;

            switch (button.Tag)
            {
                case "empty":
                    frm.Navigate(new AddTrackerPage(popTrackerPop));
                    break;
                default:
                    break;

            }

            popTrackerPop.IsOpen = true;

        }
    }
}
