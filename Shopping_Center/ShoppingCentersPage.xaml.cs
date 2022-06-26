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
    /// Логика взаимодействия для ShoppingCentersPage.xaml
    /// </summary>
    public partial class ShoppingCentersPage : Page
    {

        public ShoppingCentersPage()
        {
            InitializeComponent();
            //DGShopCenter.ItemsSource = ShoppingCenterEntities.GetContext().Shopping_centers.ToList();
            ComboCity.ItemsSource = ShoppingCenterEntities.GetContext().Shopping_centers.Select(x => x.City).Distinct().ToList();
            ComboStatus.ItemsSource = ShoppingCenterEntities.GetContext().Shopping_centers.Where(x => x.Status != "Удален").Select(x => x.Status).Distinct().ToList();
        }


        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddShoppingCenters((sender as Button).DataContext as Shopping_centers));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddShoppingCenters(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {// полчение списка для удаления
            var SHCentersForRemoving = DGShopCenter.SelectedItems.Cast<Shopping_centers>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {SHCentersForRemoving.Count()}?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ShoppingCenterEntities.GetContext().Shopping_centers.RemoveRange(SHCentersForRemoving);
                    ShoppingCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены.");

                    DGShopCenter.ItemsSource = ShoppingCenterEntities.GetContext().Shopping_centers.ToList();

                }
                catch (Exception ex)//фикс изменений
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ShoppingCenterEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGShopCenter.ItemsSource = ShoppingCenterEntities.GetContext().Shopping_centers.ToList();
            }
        }

        private void BtnGoPavilions_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PavilionsPage(null));
        }

        private void ComboCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = ComboCity.SelectedItem;
            List<Shopping_centers> SearchType = null;
            SearchType = ShoppingCenterEntities.GetContext().Shopping_centers.Where(b => b.City == c.ToString()).ToList();
            DGShopCenter.ItemsSource = SearchType;
        }

        private void ComboStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = ComboStatus.SelectedItem;
            List<Shopping_centers> SearchType = null;
            SearchType = ShoppingCenterEntities.GetContext().Shopping_centers.Where(b => b.Status == c.ToString() && b.Status != "Удален").ToList();
            DGShopCenter.ItemsSource = SearchType;
        }
    }
}