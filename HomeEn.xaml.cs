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
   
    public partial class HomeEn : Window
    {
        public HomeEn()
        {
            InitializeComponent();
        }

        private void NewWords_Click(object sender, RoutedEventArgs e)
        {
            Newwords g = new Newwords();
            this.Close();
            g.Show();
        }

        private void Sett_Click(object sender, RoutedEventArgs e)
        {
            Settengl h = new Settengl();
            this.Close();
            h.Show();
        }

        private void ABoutme_Click(object sender, RoutedEventArgs e)
        {
            Aboutme i = new Aboutme();
            this.Close();
            i.Show();
        }

        private void MyWord_Click(object sender, RoutedEventArgs e)
        {
            MyWordenglv j = new MyWordenglv();
            this.Close();
            j.Show();
        }

        
    }
}
