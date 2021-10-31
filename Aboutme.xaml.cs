using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace applernnewwords
{
    /// <summary>
    /// Логика взаимодействия для Aboutme.xaml
    /// </summary>
    public partial class Aboutme : Window
    {
        public Aboutme()
        {
            InitializeComponent();
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            HomeEn j = new HomeEn();
            this.Close();
            j.Show();
        }

        private void NewWord_Click(object sender, RoutedEventArgs e)
        {
            Newwords k = new Newwords();
            this.Close();
            k.Show();
        }

        private void Sett_Click(object sender, RoutedEventArgs e)
        {
            Settengl l = new Settengl();
            this.Close();
            l.Show();
        }

        private void MyWord_Click(object sender, RoutedEventArgs e)
        {
            MyWordenglv j = new MyWordenglv();
            this.Close();
            j.Show();
        }

       
    }
}
