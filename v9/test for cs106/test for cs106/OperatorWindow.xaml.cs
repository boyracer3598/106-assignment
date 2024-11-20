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
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Runtime.CompilerServices;

namespace test_2
{
    
    

    public partial class OperatorWindow : Window
    {

        
       
        public OperatorWindow()
        {
            InitializeComponent();
        }

        private void LoadText()
        {
            try
            {
                Usertext.Content = Login.currentUserN;

                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Tickets.csv";

                List<(string, List<string>)> csvData;
                

                csvData = CsvReaderL.ReadCsv(filename);

                if (csvData.Count >= 1)
                {
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        var Row = csvData[i];

                        

                    }
                }

               




            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

       

        
        private void Assign(object sender, EventArgs e)
        {

        }
        

    }
}

