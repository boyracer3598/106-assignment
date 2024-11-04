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
    
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string currentUser;

        private void GoAccount(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Application.Current.Windows.OfType<Login>().SingleOrDefault()?.Close();
        }
        
       

        

        

        

        

        
        private void ELostL(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "Email";
            }
        }

        private void EGainedL(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "Email")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "";
            }
        }

        private void PLostL(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "Password";
            }
        }

        private void PGainedL(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "Password")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "";
            }
        }

        

        

        string User;
        string Pass;
        bool noUser;
        private void StartLoginL(object sender, RoutedEventArgs e)
        {
            
            

            try
            {
                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Accounts.csv";
                Trace.WriteLine(filename);
                MainWindow.CleanFile(filename);
                List<(string, List<string>)> csvData;

                User = Email.Text;
                Pass = Password.Text;

                csvData = CsvReaderL.ReadCsv(filename);

                // Check if there is a second row
                if (csvData.Count >= 1)
                {
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        var Row = csvData[i]; // Index 1 for the second row

                        if (Row.Item2[3] == User && Row.Item2[2] == Pass)
                        {
                            currentUser = Row.Item1 + "\n" + Row.Item2[1];
                            noUser = false; break;
                            
                        }
                        else
                        {
                            noUser= true;
                        }
                    }

                    if (noUser == false)
                    {
                        MessageBox.Show("login success");
                        System.Threading.Thread.Sleep(50);
                        TicketWindow ticketsubmissionwindow = new TicketWindow();
                        ticketsubmissionwindow.Show();
                        Application.Current.Windows.OfType<Login>().SingleOrDefault()?.Close();

                    }
                    else
                    {
                        MessageBox.Show("login failed");
                    }

                   
                }
                else
                {
                    Console.WriteLine("The CSV file does not have a second row.");
                    MessageBox.Show("there is no second row");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }

        private void FinishProgram(object sender, RoutedEventArgs e)
        {
            // Close the program
            Close();
        }

        private void windowHide()
        {

        }
    }

    

    public class CsvReaderL
    {
        public static List<(string, List<string>)> ReadCsv(string filename)
        {
            var result = new List<(string, List<string>)>();

            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var values = new List<string>();
                    var cells = line.Split(',');

                    foreach (var cell in cells)
                    {
                        values.Add(cell);
                    }

                    // Ensure there's at least one value before adding to the result
                    if (values.Count > 0)
                    {
                        result.Add((values[0], values));
                    }
                }
            }

            return result;
        }
    }
}

