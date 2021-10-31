using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void NewWords_Click(object sender, RoutedEventArgs e)
        {
            Enwords y = new Enwords();
            this.Close();
            y.Show();
        }

        private void IrgWords_Click(object sender, RoutedEventArgs e)
        {
            Iragwen h = new Iragwen();
            this.Close();
            h.Show();
        }

        private void Set_Click(object sender, RoutedEventArgs e)
        {
            Settp k = new Settp();
            this.Close();
            k.Show();
        }

        private void proProg_Click(object sender, RoutedEventArgs e)
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

    }
}
