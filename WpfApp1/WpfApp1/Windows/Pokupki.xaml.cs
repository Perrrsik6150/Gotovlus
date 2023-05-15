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

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для Pokupki.xaml
    /// </summary>
    public partial class Pokupki : Window
    {
        public Pokupki()
        {
            InitializeComponent();
            PokupkiGrid.ItemsSource = ShopEntities.GetContext().Pokupka.ToList();
        }

        private void Vernut (object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Owner = this;
            mainWindow.Show();
            this.Hide();
        }

        private void Dobavit(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var pokupkaForRemoving = PokupkiGrid.SelectedItems.Cast<Pokupka>().ToList();
            if(MessageBox.Show("Вы уверены, что хотите удалить данные?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning)
                == MessageBoxResult.Yes)
            {
                try
                {
                    ShopEntities.GetContext().Pokupka.RemoveRange(pokupkaForRemoving);
                    ShopEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                    PokupkiGrid.ItemsSource = ShopEntities.GetContext().Pokupka.ToList();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }
            }
        }
    }
}
