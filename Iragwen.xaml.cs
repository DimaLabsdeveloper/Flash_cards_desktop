using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
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

    public partial class Iragwen : Window
    {
        public Iragwen()
        {
            InitializeComponent();
            ukr.Visibility = Visibility.Hidden;
        }
        int ID = 0;
        int rollenum = 0;
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            this.Close();
            b.Show();
        }
        
        private void newWords_Click(object sender, RoutedEventArgs e)
        {
            Enwords y = new Enwords();
            this.Close();
            y.Show();
        }

        private void Ukrwords_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {

                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./New_word.db"))
                {


                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Ireg WHERE id =" + ID, cn))
                    {

                        cn.Open();

                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                        {

                            if (dataReader.HasRows)
                            {

                                while (dataReader.Read())
                                {
                                    engl.Content = (dataReader.GetString(1)) + "             " + (dataReader.GetString(2)) + "         " + (dataReader.GetString(3));

                                }

                            }
                        }
                    }
                }
                if (ukr.Content == "")
                {
                    MessageBox.Show("це було останнє слово");
                    Iragwen f = new Iragwen();
                    this.Close();
                    f.Show();

                }
            }
            catch
            {
                engl.Visibility = Visibility.Hidden;
                MessageBox.Show("Ой, винекла якась проблема");
            }

        }

        private void Sett_Click_1(object sender, RoutedEventArgs e)
        {
            Settp k = new Settp();
            this.Close();
            k.Show();
        }

        private void next_Click_2(object sender, RoutedEventArgs e)
        {

            ukr.Visibility = Visibility.Visible;
            info.Content = " Натисніть на слово, щоб побачити три форми дієслова";
            
            ukr.Content = "";
            engl.Content = "";
            try
            {
                
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./New_word.db"))
                {
                    ID++;

                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Ireg WHERE id =" + ID, cn))
                    {

                        cn.Open();

                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                        {

                            if (dataReader.HasRows)
                            {

                                while (dataReader.Read())
                                {
                                    ukr.Content = (dataReader.GetString(4));

                                }

                            }
                            if (ukr.Content == "")
                            {
                                MessageBox.Show("це було останнє слово");
                                Iragwen f = new Iragwen();
                                this.Close();
                                f.Show();

                            }
                        }
                    }
                    
                }
              
            }
            catch
            {
                engl.Visibility = Visibility.Hidden;
                MessageBox.Show("Ой, виникла якась помилка :(");
            }

        }

        private void proprog_Click_3(object sender, RoutedEventArgs e)
        {
            Proprog j = new Proprog();
            this.Close();
            j.Show();
        }

        private void MyWords_Click_4(object sender, RoutedEventArgs e)
        {
            Myword k = new Myword();
            this.Close();
            k.Show();
        }



    }
}
