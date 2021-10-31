using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Threading;

namespace applernnewwords
{

    public partial class Lernuk : Window
    {
        public Lernuk()
        {
            InitializeComponent();
            englbutton.Visibility = Visibility.Hidden;
            deleteword.Visibility = Visibility.Hidden;

        }
        int ID = -1;
        int rollenum = 0;
        int idDb;
        private void home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow o = new MainWindow();
            o.Show();
            this.Close();
        }

        private void ireg_Click(object sender, RoutedEventArgs e)
        {

            Iragwen q = new Iragwen();
            this.Close();
            q.Show();
        }

        private void myword_Click(object sender, RoutedEventArgs e)
        {
            Myword k = new Myword();
            k.Show();
            this.Close();
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
           

           
            if (ID < rollenum-1)
            {
                ID++;
            }
            else
            {
                MessageBox.Show("Це останнє слово");
                Lernuk g = new Lernuk();
                this.Close();
                g.Show();
            }
            
            englbutton.Visibility = Visibility.Visible;
            deleteword.Visibility = Visibility.Visible;
            text.Content = "Натисніть на слово, щоб побачити переклад";

            ukrlabel.Content = "";
            englbutton.Content = "";


            using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./coolword.db"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words LIMIT 1 OFFSET " + ID, cn))
                {
                    cn.Open();

                   
                    using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {

                            while (dataReader.Read())
                            {
                                englbutton.Content = (dataReader.GetString(2));
                                idDb = (dataReader.GetInt32(0));
                                
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
        private void newword_Click(object sender, RoutedEventArgs e)
        {
            Enwords h = new Enwords();
            h.Show();
            this.Close();
        }

        private void proprog_Click(object sender, RoutedEventArgs e)
        {
            Proprog j = new Proprog();
            this.Close();
            j.Show();
        }

        private void sett_Click(object sender, RoutedEventArgs e)
        {
            Settp p = new Settp();
            this.Close();
            p.Show();
        }
        private void englbutton_Click(object sender, RoutedEventArgs e)//кнопка з англ словом на яку натискаєш і появляється укр мова
        {
            englbutton.Visibility = Visibility.Visible;
            ukrlabel.Content = "";
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./coolword.db"))
                {


                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words LIMIT 1 OFFSET " + ID, cn))
                    {

                        cn.Open();

                        using (SQLiteDataReader dataReader = cmd.ExecuteReader())
                        {

                            if (dataReader.HasRows)
                            {

                                while (dataReader.Read())
                                {

                                    ukrlabel.Content = (dataReader.GetString(1));

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

        private void Deleteword_Click(object sender, RoutedEventArgs e)//кнопка видалити
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=./coolword.db"))
                {


                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Words WHERE id =" + idDb, cn))
                    {

                        cn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Слово видалене!");
                        ID++;

                        Lernuk g = new Lernuk();
                        this.Close();
                        g.Show();


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

