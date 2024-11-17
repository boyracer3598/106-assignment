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
using static System.Net.Mime.MediaTypeNames;

namespace test_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TicketWindow : Window
    {
        private string RbutUnH = "";
        public TicketWindow()
        {
            InitializeComponent();
            Loaded += ticketWindow_loaded;
        }

       private void ticketWindow_loaded(object sender, RoutedEventArgs e)
        {
            Usertext.Content = Login.currentUser;
        }

        public void dashboardC(object sender, RoutedEventArgs e)
        {

        }

        public void TicketC(object sender, RoutedEventArgs e)
        {

        }

        public void InboxC(object sender, RoutedEventArgs e)
        {

        }

        public void NotificationsC(object sender, RoutedEventArgs e)
        {

        }

        public void FeedbackC(object sender, RoutedEventArgs e)
        {

        }

        private void PLowS(object sender, RoutedEventArgs e)
        {
            //Low1I.Source = new BitmapImage(new Uri(@"/resources/LowD.png", UriKind.Relative));
        }

        private void PMedS(object sender, RoutedEventArgs e)
        {
            //Med1I.Source = new BitmapImage(new Uri(@"/resources/MedD.png", UriKind.Relative));
        }

        private void PHighS(object sender, RoutedEventArgs e)
        {
            //High1I.Source = new BitmapImage(new Uri(@"/resources/HighD.png", UriKind.Relative));
        }

        private void SLowS(object sender, RoutedEventArgs e)
        {
            //Low1I.Source = new BitmapImage(new Uri(@"/resources/LowD.png", UriKind.Relative));
        }

        private void SMedS(object sender, RoutedEventArgs e)
        {
            //Med1I.Source = new BitmapImage(new Uri(@"/resources/MedD.png", UriKind.Relative));
        }

        private void SHighS(object sender, RoutedEventArgs e)
        {
            //High1I.Source = new BitmapImage(new Uri(@"/resources/HighD.png", UriKind.Relative));
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

