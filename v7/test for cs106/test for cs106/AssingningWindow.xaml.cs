using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace test_2
{

    public partial class AssingningWindow : Window
    {
        public AssingningWindow()
        {
            InitializeComponent();
        }

        private void dashboardC(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void FeedbackC(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void InboxC(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void NotificationsC(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void TicketC(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void ELostL(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "Search";
            }
        }

        private void EGainedL(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "Search")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "";
            }
        }

    }
}

