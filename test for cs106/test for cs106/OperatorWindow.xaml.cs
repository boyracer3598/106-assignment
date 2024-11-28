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
        int tikselect = 1;
        int OpSelect = 1;
        string OpSelectname = "";
        string Op1name = "";
        string Op2name = "";
        string Op3name = "";


        

        public OperatorWindow()
        {
            InitializeComponent();

            LoadText();

            

            
        }

        private void LoadText()
        {
            try
            {
                //get the file path for the accounts file and clean it
                //then read the file and get the data
                //then loop through the data and get the second ro

                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename2 = newPath += "data\\Accounts.csv";
                MainWindow.CleanFile(filename2);

                List<(string, List<string>)> csvData2;

                csvData2 = CsvReaderL.ReadCsv(filename2);

                if (csvData2.Count >= 1)
                {
                    int count = 0;
                    for (int i = 0; i < csvData2.Count; i++)
                    {
                        var Row = csvData2[i];

                        if (Row.Item2[4] == "1")
                        {
                            count++;
                            Op1.Content = Row.Item1 + " " + Row.Item2[1];
                            Op1name = Row.Item1 + " " + Row.Item2[1];

                            if (count == 1 && Row.Item2[4] == "1")
                            {
                                Op2.Content = Row.Item1 + " " + Row.Item2[1];
                                Op2name = Row.Item1 + " " + Row.Item2[1];

                            }
                            if (count == 2 && Row.Item2[4] == "1")
                            {
                                Op3.Content = Row.Item1 + " " + Row.Item2[1];
                                Op3name = Row.Item1 + " " + Row.Item2[1];
                            }
                            if (count == 3)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }

            try
            {
                Usertext.Content = Login.currentUser;
                
               

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

                        if (i == 0)
                        {
                            description.Text = Row.Item2[2];
                            tik1text.Content = Row.Item1;
                        }

                        if (i == 1)
                        {
                            tik2text.Content = Row.Item1;
                        }

                        if (i == 2)
                        {
                            tik3text.Content = Row.Item1;
                        }   
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
            //reads the tickets file and gets the data
            MessageBox.Show("Ticket assigned");
            try
            {
                if (OpSelect == 1)
                {
                    OpSelectname = Op1name;
                }
                if (OpSelect == 2)
                {
                    OpSelectname = Op2name;
                }
                if (OpSelect == 3)
                {
                    OpSelectname = Op3name;
                }



                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath + "data\\Tickets.csv";
                string filename2 = newPath + "data\\assigned.csv";
                MainWindow.CleanFile(filename);
                MainWindow.CleanFile(filename2);
                List<(string, List<string>)> csvData;

                csvData = CsvReaderL.ReadCsv(filename);

                if (csvData.Count >= 1)
                {
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        var Row = csvData[i];

                        //then loops through the data and gets to the selected ticket
                        //then writes the Operator name to the ticket row in the file
                        if (i == tikselect - 1)
                        {
                            //Row.Item2[7] = OpSelectname;
                            //then writes the data to the temp file
                            string csvInfo = Row.Item1 + ',' + Row.Item2[1] + ',' + Row.Item2[2] + ',' + Row.Item2[3] + ',' + Row.Item2[4] + ',' + Row.Item2[5] + ',' + Row.Item2[6] + ',' + OpSelectname + '\n';
                            File.AppendAllText(filename2, csvInfo);
                        }

                        


                    }
                }

            
                


               
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }



        }

        private void tik1click(object sender, EventArgs e)
        {
            tikselect = 1;
            try
            {
                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Tickets.csv";
                MainWindow.CleanFile(filename);
                List<(string, List<string>)> csvData;

                csvData = CsvReaderL.ReadCsv(filename);

                if (csvData.Count >= 1)
                {
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        var Row = csvData[i];

                        if (i == 0)
                        {
                            description.Text = Row.Item2[2];
                            tik1text.Content = Row.Item1;
                            typebox.Text = Row.Item2[1];
                            UserT.Content = Row.Item2[6];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        private void tik1click2(object sender, EventArgs e)
        {

            tikselect = 2;
            try
            {
                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Tickets.csv";
                MainWindow.CleanFile(filename);
                List<(string, List<string>)> csvData;

                csvData = CsvReaderL.ReadCsv(filename);

                if (csvData.Count >= 1)
                {
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        var Row = csvData[i];

                        if (i == 1)
                        {
                            description.Text = Row.Item2[2];
                            tik2text.Content = Row.Item1;
                            typebox.Text = Row.Item2[1];
                            UserT.Content = Row.Item2[6];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        private void tik1click3(object sender, EventArgs e)
        {
            tikselect = 3;
            try
            {
                string appCurrentFile = System.AppDomain.CurrentDomain.BaseDirectory;
                Trace.WriteLine(appCurrentFile);
                string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(appCurrentFile, @""));
                string filename = newPath += "data\\Tickets.csv";
                MainWindow.CleanFile(filename);
                List<(string, List<string>)> csvData;

                csvData = CsvReaderL.ReadCsv(filename);

                if (csvData.Count >= 1)
                {
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        var Row = csvData[i];

                        if (i == 2)
                        {
                            description.Text = Row.Item2[2];
                            tik3text.Content = Row.Item1;
                            typebox.Text = Row.Item2[1];
                            UserT.Content = Row.Item2[6];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        private void Op1Ass(object sender, RoutedEventArgs e)
        {
            OpSelect = 1;
            MessageBox.Show("Operator 1 selected");
        }

        private void Op2Ass(object sender, RoutedEventArgs e)
        {
            OpSelect = 2;
            MessageBox.Show("Operator 2 selected");
        }

        private void Op3Ass(object sender, RoutedEventArgs e)
        {
            OpSelect = 3;
            MessageBox.Show("Operator 3 selected");
        }

        private void backButton(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}

