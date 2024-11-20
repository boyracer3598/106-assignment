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

    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            Loadtext();
        }

        public void Loadtext()
        {
            try
            {
                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Accounts.csv";

                MessageBox.Show(filename);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

    }
}

