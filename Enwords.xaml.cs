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
    
    public partial class Enwords : Window
    {

        public Enwords()
        {
            InitializeComponent();
            engl.Visibility = Visibility.Hidden;
        }
        int ID = 0;

        

        
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            this.Close();
            b.Show();
        }

        private void Ireg_Click(object sender, RoutedEventArgs e)
        {
            Iragwen h = new Iragwen();
            this.Close();
            h.Show();
        }

        private void Sett_Click(object sender, RoutedEventArgs e)
        {
            Settp k = new Settp();
            this.Close();
            k.Show();
        }
        
        
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            engl.Visibility = Visibility.Visible;
            use.Content = "Натисніть на слово, щоб побачити переклад";

            ukr.Content = "           ";

            try
            {


                engl.Content = "";




                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./New_word.db"))
                {
                    ID++;

                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words WHERE id =" + ID, cn))
                    {

                        cn.Open();

                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                        {

                            if (dataReader.HasRows)
                            {

                                while (dataReader.Read())
                                {
                                    engl.Content = (dataReader.GetString(1));

                                }

                            }
                        }
                    }
                }
                if (engl.Content == "")
                {
                    MessageBox.Show("це було останнє слово");
                    Enwords f = new Enwords();
                    this.Close();
                    f.Show();

                }
            }
            catch
            {
                engl.Visibility = Visibility.Hidden;
                MessageBox.Show("Ой, виникла якась помилка :(");
            }

        }
        private void Aboutme_Click(object sender, RoutedEventArgs e)
        {
            Proprog j = new Proprog();
            this.Close();
            j.Show();
        }

        private void Myword_Click(object sender, RoutedEventArgs e)
        {
            Myword k = new Myword();
            this.Close();
            k.Show();
        }

        private void Engl_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./New_word.db"))
                {


                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words WHERE id =" + ID, cn))
                    {

                        cn.Open();

                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                        {

                            if (dataReader.HasRows)
                            {

                                while (dataReader.Read())
                                {
                                    ukr.Content = (dataReader.GetString(2));
                                }

                            }
                        }
                    }
                }

            }

            catch
            {

                MessageBox.Show("Ой, виникла якась помилка :(");
            }
        }
    }
}
