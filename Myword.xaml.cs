using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
   
    public partial class Myword : Window
    {
        public Myword()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sett_Click(object sender, RoutedEventArgs e)
        {
            Settp k = new Settp();
            this.Close();
            k.Show();
        }

        private void addword_Click(object sender, RoutedEventArgs e)
        {
            Addword h = new Addword();
            this.Close();
            h.Show();
        }

       

        private void newWords_Click(object sender, RoutedEventArgs e)
        {
            Enwords y = new Enwords();
            this.Close();
            y.Show();
        }

        private void Irag_Click(object sender, RoutedEventArgs e)
        {
            Iragwen h = new Iragwen();
            this.Close();
            h.Show();
        }

        private void Proprog_Click(object sender, RoutedEventArgs e)
        {
            Proprog j = new Proprog();
            this.Close();
            j.Show();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            this.Close();
            b.Show();
        }

        private void LernWords_Click(object sender, RoutedEventArgs e)
        {

            Lernuk i = new Lernuk();
            this.Close();
            i.Show();
        }

        
    }
}
