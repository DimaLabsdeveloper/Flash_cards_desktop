
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

namespace applernnewwords
{
    
    public partial class Addword : Window
    {
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
        public Addword()
        {
            InitializeComponent();
            
        }

        private void myword_Click(object sender, RoutedEventArgs e)
        {
            Myword k = new Myword();
            this.Close();
            k.Show();
        }

        private void newword_Click(object sender, RoutedEventArgs e)
        {
            Enwords y = new Enwords();
            this.Close();
            y.Show();
        }

        private void proprog_Click(object sender, RoutedEventArgs e)
        {
            Proprog j = new Proprog();
            this.Close();
            j.Show();
        }

        private void sett_Click(object sender, RoutedEventArgs e)
        {
            Settp k = new Settp();
            this.Close();
            k.Show();
        }

        private void ireg_Click(object sender, RoutedEventArgs e)
        {
            Iragwen h = new Iragwen();
            this.Close();
            h.Show();
        }
        
        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ukrword.Text == "" && englword.Text == "") { erreor.Content = "                 введіть слова"; }
                else if (ukrword.Text == "") { erreor.Content = "            введіть українське слово"; }
                else if (englword.Text == "") { erreor.Content = "            введіть англійське слово"; }
                else
                {

                    using (SQLiteConnection myConnection = new SQLiteConnection(@"Data Source=./coolword.db"))
                    {
                        string CommandText = "INSERT INTO Words (ukr,engl) VALUES ('" + ukrword.Text + "','" + englword.Text + "');";

                        using (SQLiteCommand myCommand = new SQLiteCommand(CommandText, myConnection))
                        {

                            myConnection.Open();

                            myCommand.ExecuteNonQuery();
                            MessageBox.Show("слово додано!");
                            erreor.Content = "    ";
                            Myword g = new Myword();
                            this.Close();
                            g.Show();
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Ой, виникла якась помилка :(");
            }
        }

        

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow j = new MainWindow();
            this.Close();
            j.Show();
        }
    }
    

}

