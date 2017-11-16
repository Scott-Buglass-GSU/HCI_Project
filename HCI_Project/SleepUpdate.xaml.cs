﻿using System;
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

        public SleepUpdate(MainWindow mw)
        {
            window = mw;
            parent = mw.popTrackerPop;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //re-enables the main for use
            window.frmMain.IsEnabled = true;
            //closes out the popup holding this page
            parent.IsOpen = false;
        }
    }
}
