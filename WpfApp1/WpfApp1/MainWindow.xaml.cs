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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPriduct (object sender, RoutedEventArgs e)
        {
            Produkts produkts = new Produkts();
            produkts.Owner = this;
            produkts.Show();
            this.Hide();
        }

        private void btnSotrudnici (object sender, RoutedEventArgs e)
        {
            Sotrudnici sotrudnici = new Sotrudnici();
            sotrudnici.Owner = this;
            sotrudnici.Show();
            this.Hide();
        }

        private void btnPokupki (object sender, RoutedEventArgs e)
        {
            Pokupki polupki = new Pokupki();
            polupki.Owner = this;
            polupki.Show();
            this.Hide();
        }

        private void Vixod (object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите выйти?", "Внимание!", 
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes) 
            { 
             this.Close();
            }
        }
    }
}
