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
    /// Логика взаимодействия для PavilionsPage.xaml
    /// </summary>
    public partial class PavilionsPage : Page
    {

        string _name;
        string _name2;
        int idShop = 0;

        public PavilionsPage(Shopping_centers shop)
        {
            InitializeComponent();
            if (shop != null)
            {
                idShop = shop.id_shopping_center;
                DGPavilions.ItemsSource = ShoppingCenterEntities.GetContext().Pavilions.Where(b => b.id_shopping_center == idShop && b.Coeff_add_price > 0.1).ToList();
            }
            else
                DGPavilions.ItemsSource = ShoppingCenterEntities.GetContext().Pavilions.ToList();
            ComboStatus.ItemsSource = ShoppingCenterEntities.GetContext().Pavilions.Select(x => x.Status).Distinct().ToList();
            ComboFloor.ItemsSource = ShoppingCenterEntities.GetContext().Pavilions.Select(x => x.Floor).Distinct().ToList();
        }

        private void BtnGoPavilions_Click(object sender, RoutedEventArgs e)
        {
            //Manager.MainFrame.Navigate(new PavilionsPage());
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddPavilionsPage());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {// получение списка для удаления
            var PavilionsForRemoving = DGPavilions.SelectedItems.Cast<Pavilions>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {PavilionsForRemoving.Count()}?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ShoppingCenterEntities.GetContext().Pavilions.RemoveRange(PavilionsForRemoving);
                    ShoppingCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены.");

                    DGPavilions.ItemsSource = ShoppingCenterEntities.GetContext().Pavilions.ToList();

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
                DGPavilions.ItemsSource = ShoppingCenterEntities.GetContext().Pavilions.ToList();
            }
        }

        private void AreaTextTo_TextChanged(object sender, TextChangedEventArgs e)
        {
            _name = AreaTextFrom.Text;
            _name2 = AreaTextTo.Text;
            double num1 = 0;
            double.TryParse(_name, out num1);
            double num2 = 0;
            double.TryParse(_name2, out num2);
            List<Pavilions> list = ShoppingCenterEntities.GetContext().Pavilions.Where(b => b.Area > num1 && b.Area < num2 && b.Coeff_add_price > 0.1).ToList();
            if (idShop != 0)
                list = list.Where(b => b.id_shopping_center == idShop).ToList();
            DGPavilions.ItemsSource = list;
        }
        private void ComboFloor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = ComboFloor.SelectedItem;
            List<Pavilions> SearchType = null;
            SearchType = ShoppingCenterEntities.GetContext().Pavilions.Where(b => b.Floor.ToString() == c.ToString() && b.Coeff_add_price > 0.1 && b.Coeff_add_price > 0.1 && b.id_shopping_center == idShop).ToList();
            DGPavilions.ItemsSource = SearchType;
        }

        private void ComboStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = ComboStatus.SelectedItem;
            List<Pavilions> SearchType = null;
            SearchType = ShoppingCenterEntities.GetContext().Pavilions.Where(b => b.Status.ToString() == c.ToString() && b.Coeff_add_price > 0.1 && b.id_shopping_center == idShop).ToList();
            DGPavilions.ItemsSource = SearchType;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddPavilionsPage((sender as Button).DataContext as Pavilions));
        }
    }
}