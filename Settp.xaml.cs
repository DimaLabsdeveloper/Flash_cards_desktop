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

namespace applernnewwords
{
   
    public partial class Settp : Window
    {
        public Settp()
        {
            InitializeComponent();
        }

        private void IregWords_Click(object sender, RoutedEventArgs e)
        {
            Iragwen h = new Iragwen();
            this.Close();
            h.Show();
        }

        private void NewWords_Click(object sender, RoutedEventArgs e)
        {
            Enwords y = new Enwords();
            this.Close();
            y.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            this.Close();
            b.Show();
        }

        private void ProProg_Click(object sender, RoutedEventArgs e)
        {
            Proprog j = new Proprog();
            this.Close();
            j.Show();
        }

        private void MyWords_Click(object sender, RoutedEventArgs e)
        {
            Myword k = new Myword();
            this.Close();
            k.Show();
        }

        private void HomeEn_Click(object sender, RoutedEventArgs e)
        {
            HomeEn t = new HomeEn();
            this.Close();
            t.Show();
        }

       
    }
}
