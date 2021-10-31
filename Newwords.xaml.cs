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
   
    public partial class Newwords : Window
    {
        
        public Newwords()
        {
            InitializeComponent();
            ENGL.Visibility = Visibility.Hidden;
        }
        int ID = 0;
        private void ENGL_Click_1(object sender, RoutedEventArgs e)
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

                                while (dataReader.Read())854
                                {
                                    ukr.Content = (dataReader.GetString(1));
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
        
        private void Next_Click(object sender, RoutedEventArgs e)
        {
            ENGL.Visibility = Visibility.Visible;
            use.Content = "click on a word to see the translation";
            try
            {


                ENGL.Content = "";
                

                

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
                                    ENGL.Content = (dataReader.GetString(2));
                                   
                                }

                            }
                        }
                    }
                }
                if (ENGL.Content == "")
                {
                    MessageBox.Show("That was the last word");
                    Newwords f = new Newwords();
                    this.Close();
                    f.Show();

                }
            }
            catch
            {
                ENGL.Visibility = Visibility.Hidden;
                MessageBox.Show("Oh, there was an error :(");
            }
            
            ukr.Content = "           ";


        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

            HomeEn f = new HomeEn();
            this.Close();
            f.Show();
        }

        private void Sett_Click(object sender, RoutedEventArgs e)
        {
            Settengl h = new Settengl();
            this.Close();
            h.Show();
        }

        private void ProProg_Click(object sender, RoutedEventArgs e)
        {
            Aboutme q = new Aboutme();
            this.Close();
            q.Show();
        }

        private void MyWords_Click(object sender, RoutedEventArgs e)
        {
            MyWordenglv j = new MyWordenglv();
            this.Close();
            j.Show();
        }

        
    }
}
