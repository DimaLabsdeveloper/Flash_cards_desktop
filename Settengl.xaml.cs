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
    /// <summary>
    /// Логика взаимодействия для Settengl.xaml
    /// </summary>
    public partial class Settengl : Window
    {
        public Settengl()
        {
            InitializeComponent();
        }

        

        private void NewWords_Click(object sender, RoutedEventArgs e)
        {
            Newwords g = new Newwords();
            this.Close();
            g.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HomeEn f = new HomeEn();
            this.Close();
            f.Show();

        }

        private void ProProg_Click(object sender, RoutedEventArgs e)
        {
            Aboutme q = new Aboutme();
            this.Close();
            q.Show();
        }

        private void MyWord_Click(object sender, RoutedEventArgs e)
        {
            MyWordenglv j = new MyWordenglv();
            this.Close();
            j.Show();
        }

        private void HomeUkr_Click(object sender, RoutedEventArgs e)
        {
            MainWindow j = new MainWindow();
            this.Close();
            j.Show();
        }

        
    }
}
