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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void GoLogin(object sender, RoutedEventArgs e)
        {
            // Go to the login page
            AdminWindow adminWindow= new AdminWindow();
            adminWindow.Show();
           //Login login = new Login();
           // login.Show();
            //Application.Current.Windows.OfType<MainWindow>().SingleOrDefault()?.Close();

            // pop out message box
            //MessageBox.Show("Go to login page");
        }

        private void TandC(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Terms and Conditions");
        }

        private void OntextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;


            // If it is empty, set the text to "Enter your username"
            if (text == "First name" && ((TextBox)sender).IsFocused == true)
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "";
            }


        }

        private void FNLost(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "First name";
            }
        }

        private void FNGained(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "First name")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "";
            }
        }

        private void LNLost(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "Last name";
            }
        }

        private void LNGained(object sender, RoutedEventArgs e)
        {
            // Get the text from the textbox
            string text = ((TextBox)sender).Text;

            // If it is empty, set the text to "Enter your username"
            if (text == "Last name")
            {
                // If it is empty, set the text to "First name"
                ((TextBox)sender).Text = "";
            }
        }

        private void ELost(object sender, RoutedEventArgs e)
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

        private void EGained(object sender, RoutedEventArgs e)
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

        private void PLost(object sender, RoutedEventArgs e)
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

        private void PGained(object sender, RoutedEventArgs e)
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

        public static void CleanFile(string filename)
        {
            try
            {
                // Open the original file and a temporary file for writing
                using (StreamReader file = new StreamReader(filename))
                using (StreamWriter temp = new StreamWriter("temp.csv"))
                {
                    string line;
                    // Read until the end of the file
                    while ((line = file.ReadLine()) != null)
                    {
                        // Check for non-empty lines that are not just commas or spaces
                        if (!string.IsNullOrWhiteSpace(line) && line[0] != ',' && line[0] != ' ')
                        {
                            temp.WriteLine(line);
                        }
                    }
                }

                // Replace the original file with the cleaned temporary file
                File.Delete(filename);
                File.Move("temp.csv", filename);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CreateAcc(object sender, RoutedEventArgs e)
        {
            string FName = null;
            string LName = null;
            string PassW = null;
            string EmailAd = null;

            if (FirstName.Text == "First name" || LastName.Text == "Last name" || Password.Text == "Password" || Email.Text == "Email")
            {
                MessageBox.Show("please enter details");
            } 
            else
            {
                
                FName = FirstName.Text; LName = LastName.Text; PassW = Password.Text; EmailAd = Email.Text;

                var csvInfo = FName + ',' + LName + ',' + PassW + ',' + EmailAd + '\n';
                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Accounts.csv";

                CleanFile(filename);

                File.AppendAllText(filename, csvInfo);

                MessageBox.Show("Account created");
                System.Threading.Thread.Sleep(50);
                Login login = new Login();
                login.Show();
                Application.Current.Windows.OfType<MainWindow>().SingleOrDefault()?.Close();
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

    public static class CsvReader
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

