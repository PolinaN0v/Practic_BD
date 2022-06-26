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
    /// Логика взаимодействия для EmplooyesPage.xaml
    /// </summary>
    public partial class EmplooyesPage : Page
    {
        public EmplooyesPage()
        {
            InitializeComponent();
            //DGEmplooyes.ItemsSource = ShoppingCenterEntities.GetContext().Emplooyes.ToList();
            ComboSurname.ItemsSource = ShoppingCenterEntities.GetContext().Emplooyes.Select(x => x.Surname).Distinct().ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEmployeesPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {// получение списка для удаления
            var EmplooyesForRemoving = DGEmplooyes.SelectedItems.Cast<Emplooyes>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {EmplooyesForRemoving.Count()}?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    ShoppingCenterEntities.GetContext().Emplooyes.RemoveRange(EmplooyesForRemoving);
                    ShoppingCenterEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены.");

                    DGEmplooyes.ItemsSource = ShoppingCenterEntities.GetContext().Emplooyes.ToList();

                }
                catch (Exception ex)//фикс изменений
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEmployeesPage((sender as Button).DataContext as Emplooyes));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ShoppingCenterEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGEmplooyes.ItemsSource = ShoppingCenterEntities.GetContext().Emplooyes.ToList();
            }
        }

        private void ComboSurname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = ComboSurname.SelectedItem;
            List<Emplooyes> SearchType = null;
            SearchType = ShoppingCenterEntities.GetContext().Emplooyes.Where(b => b.Surname == c.ToString()).ToList();
            DGEmplooyes.ItemsSource = SearchType;
        }
    }
}