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
                Cuser.Content = Login.currentUserN;

                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Accounts.csv";

                List<(string, List<string>)> csvData;
                List<string> ONames;

                ONames = new List<string>();

                List<string> UNames;

                UNames = new List<string>();

                csvData = CsvReaderL.ReadCsv(filename);

                if (csvData.Count >= 1)
                {
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        var Row = csvData[i];

                        if (Row.Item2[4] == "1")
                        {
                            ONames.Add(Row.Item1 + " " + Row.Item2[1]);
                        }

                        if (Row.Item2[4] == "0")
                        {
                            UNames.Add(Row.Item1 + " " + Row.Item2[1]);
                        }
                        
                    }
                }

                if (ONames.Count > 0)
                {
                    op1.Content = ONames[0];
                    op2.Content = ONames[1];
                }
                if (UNames.Count > 0)
                {
                    User1.Content = UNames[0];
                    User2.Content = UNames[1];
                    User3.Content = UNames[2];
                    User4.Content = UNames[3];
                }

                

                
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        private void View_User(object sender, EventArgs e)
        {
            string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
            Trace.WriteLine(appCurrentFile);
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
            string filename = newPath += "data\\Accounts.csv";

           
            List<(string, List<string>)> csvData;
            

            List<string> UNames;

            UNames = new List<string>();

            csvData = CsvReaderL.ReadCsv(filename);

            if (csvData.Count >= 1)
            {
                for (int i = 0; i < csvData.Count; i++)
                {
                    var Row = csvData[i];

                    if (Row.Item2[4] == "0")
                    {
                        UNames.Add(Row.Item1 + " " + Row.Item2[1]);
                    }


                }
            }

            string Users = "";

            for (int i = 0; i < UNames.Count; i++)
            {
                Users += "\n" + UNames[i];
            }

            MessageBox.Show(Users);
        }

    }
}

