using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace applernnewwords
{
   
    public partial class Addwordengv : Window
    {
        public Addwordengv()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (ukrword.Text == "" && englword.Text == "") { erreor.Content = "                 enter the words"; }
                else if (ukrword.Text == "") { erreor.Content = "             enter the Ukrainian word"; }
                else if (englword.Text == "") { erreor.Content = "               enter an English word"; }
                else
                {







                    string cs = @"Data Source=./coolword.db";



                    string CommandText = "INSERT INTO Words (ukr,engl) VALUES ('" + ukrword.Text + "','" + englword.Text + "');";
                    using (SQLiteConnection myConnection = new SQLiteConnection(cs))
                    {

                        using (SQLiteCommand myCommand = new SQLiteCommand(CommandText, myConnection))
                        {

                            myConnection.Open();

                            myCommand.ExecuteNonQuery();
                            MessageBox.Show("word is added!");
                            erreor.Content = "    ";
                            HomeEn g = new HomeEn();
                            this.Close();
                            g.Show();
                        }
                    }


                }
            }
            catch
            {
                MessageBox.Show("Oh, there was an error :(");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HomeEn o = new HomeEn();
            this.Close();
            o.Show();
        }

        private void My_Click(object sender, RoutedEventArgs e)
        {
            MyWordenglv j = new MyWordenglv();
            this.Close();
            j.Show();
        }

        private void Me_Click(object sender, RoutedEventArgs e)
        {
            Aboutme i = new Aboutme();
            this.Close();
            i.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Settengl h = new Settengl();
            this.Close();
            h.Show();
        }

        private void _new_Click(object sender, RoutedEventArgs e)
        {
            Newwords g = new Newwords();
            this.Close();
            g.Show();
        }

        private void _new_Click_1(object sender, RoutedEventArgs e)
        {
            Newwords g = new Newwords();
            this.Close();
            g.Show();
        }
    }
    }

