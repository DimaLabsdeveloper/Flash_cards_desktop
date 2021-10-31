using MySql.Data.MySqlClient;
using System;
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
using System.IO;
using System.Threading;

namespace applernnewwords
{

    public partial class LernmywordEnglv : Window
    {
        public LernmywordEnglv()
        {
            InitializeComponent();
            englbutton.Visibility = Visibility.Hidden;
            deleteword.Visibility = Visibility.Hidden;
        }
        int id = -1;
        int rollenum = 0;
        int idDb;


        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HomeEn f = new HomeEn();
            this.Close();
            f.Show();
        }

        private void Newwords_Click(object sender, RoutedEventArgs e)
        {
            Newwords g = new Newwords();
            this.Close();
            g.Show();
        }

        private void My_Click(object sender, RoutedEventArgs e)
        {
            MyWordenglv j = new MyWordenglv();
            this.Close();
            j.Show();
        }

        private void Sett_Click(object sender, RoutedEventArgs e)
        {
            Settengl h = new Settengl();
            this.Close();
            h.Show();
        }

        private void AboutMe_Click(object sender, RoutedEventArgs e)
        {
            Aboutme i = new Aboutme();
            this.Close();
            i.Show();
        }

        private void Next_Click(object sender, RoutedEventArgs e)//кнопка далі
        {
            try
            {
            using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./coolword.db"))
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT count(*) FROM Words", cn))
            {

                cn.Open();

                using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                {

                    if (dataReader.HasRows)
                    {

                        while (dataReader.Read())
                        {

                            rollenum = (dataReader.GetInt32(0));

                        }

                    }
                }
            }
            
            if (id < rollenum - 1)
            {
                id++;
            }
            else
            {
                MessageBox.Show("This is the last word");
                LernmywordEnglv g = new LernmywordEnglv();
                this.Close();
                g.Show();
            }
            
            
                englbutton.Content = "";
                ukrlabel.Content = "";
                englbutton.Visibility = Visibility.Visible;
                deleteword.Visibility = Visibility.Visible;
                text.Content = "Click on a word to see the translation";
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./coolword.db"))
                {
                   
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words LIMIT 1 OFFSET " + id, cn))
                    {

                        cn.Open();

                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                        {

                            if (dataReader.HasRows)
                            {

                                while (dataReader.Read())
                                {
                                    englbutton.Content = (dataReader.GetString(1));
                                    idDb = (dataReader.GetInt32(0));
                                }

                            }
                        }
                    }
                }

            }
            catch
            {
                englbutton.Visibility = Visibility.Hidden;
                MessageBox.Show("Oh, there was an error :(");
            }
        }

        private void Englbutton_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./coolword.db"))
                {



                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words LIMIT 1 OFFSET " + id, cn))
                    {

                        cn.Open();

                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                        {

                            if (dataReader.HasRows)
                            {

                                while (dataReader.Read())
                                {

                                    ukrlabel.Content = (dataReader.GetString(2));

                                }

                            }
                        }
                    }
                }
            }

            catch
            {

                MessageBox.Show("Oh, there was an error :(");
            }
        }

        private void Deleteword_Click(object sender, RoutedEventArgs e)
        
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./coolword.db"))
                {


                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Words WHERE id =" + idDb, cn))
                    {

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Word is deleted!");
                        id++;

                        LernmywordEnglv g = new LernmywordEnglv();
                        this.Close();
                        g.Show();


                    }
                }
            }
            catch
            {
                MessageBox.Show("Oh, there was an error :(");
            }
        }

        
    }
}
