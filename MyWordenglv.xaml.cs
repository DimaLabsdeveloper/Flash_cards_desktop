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
    public partial class MyWordenglv : Window
    {
        public MyWordenglv()
        {
            InitializeComponent();
        }

        private void AddWord_Click(object sender, RoutedEventArgs e)
        {
            Addwordengv j = new Addwordengv();
            this.Close();
            j.Show();
        }

        private void LearnMyWords_Click(object sender, RoutedEventArgs e)
        {
            LernmywordEnglv h = new LernmywordEnglv();
            this.Close();
            h.Show();
        }

        

        private void NewWord_Click(object sender, RoutedEventArgs e)
        {
            Newwords j = new Newwords();
            this.Close();
            j.Show();
        }

        private void Proprog_Click(object sender, RoutedEventArgs e)
        {
            Aboutme q = new Aboutme();
            this.Close();
            q.Show();
        }

        private void Sett_Click(object sender, RoutedEventArgs e)
        {
            Settengl h = new Settengl();
            this.Close();
            h.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HomeEn o = new HomeEn();
            this.Close();
            o.Show();
        }

       
    }
}
