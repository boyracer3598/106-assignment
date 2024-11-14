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
        int PriorityState = 0;
        int SupportState = 0;
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
            PriorityState = 1;
        }

        private void PMedS(object sender, RoutedEventArgs e)
        {
            PriorityState = 2;
        }

        private void PHighS(object sender, RoutedEventArgs e)
        {
            PriorityState = 3;
        }

        private void SLowS(object sender, RoutedEventArgs e)
        {
            SupportState = 1;
        }

        private void SMedS(object sender, RoutedEventArgs e)
        {
            SupportState = 2;
        }

        private void SHighS(object sender, RoutedEventArgs e)
        {
            SupportState = 3;
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

        private void Submit(object sender, RoutedEventArgs e)
        {
            string type = null;
            try
            {
                if (Type.SelectedItem != null)
                {
                    type = Type.SelectedValue.ToString();
                }
                else
                {
                    MessageBox.Show("please select a type");
                    return;
                }
                string ticketname = TicketName.Text;
                string description = Description.Text;
                if (SupportState == 0 || PriorityState == 0) 
                {
                    MessageBox.Show("please select a priority or support level");
                    return;
                }
                String tags = Tags.Text;

                if (ticketname == "" || description == "")
                {
                    MessageBox.Show("please fill in all info related to your problem");
                    return;
                }
                MessageBox.Show(ticketname + " " + type + " " + description + " " + PriorityState + " " + SupportState + " " + tags);


            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

    }
}

