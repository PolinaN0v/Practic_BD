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

namespace Shopping_Center
{
    /// <summary>
    /// Логика взаимодействия для RentersPage.xaml
    /// </summary>
    public partial class RentersPage : Page
    {
        public RentersPage()
        {
            InitializeComponent();
            DGRenters.ItemsSource = ShoppingCenterEntities.GetContext().Renters.ToList();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ShoppingCenterEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGRenters.ItemsSource = ShoppingCenterEntities.GetContext().Renters.ToList();
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddRentersPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {// полчение списка для удаления
            var RentersForRemoving = DGRenters.SelectedItems.Cast<Renters>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {RentersForRemoving.Count()}?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ShoppingCenterEntities.GetContext().Renters.RemoveRange(RentersForRemoving);
                    ShoppingCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены.");

                    DGRenters.ItemsSource = ShoppingCenterEntities.GetContext().Renters.ToList();

                }
                catch (Exception ex)//фикс изменений
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddRentersPage((sender as Button).DataContext as Renters));
        }
    }
}