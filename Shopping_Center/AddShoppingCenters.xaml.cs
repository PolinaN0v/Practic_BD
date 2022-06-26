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
    /// Логика взаимодействия для AddShoppingCenters.xaml
    /// </summary>
    public partial class AddShoppingCenters : Page
    {
        private Shopping_centers _currentSHCenter = new Shopping_centers();

        public AddShoppingCenters(Shopping_centers selectedSHCenter)
        {
            InitializeComponent();

            if (selectedSHCenter != null)
                _currentSHCenter = selectedSHCenter;

            DataContext = _currentSHCenter;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        { // sb для хранения ошибок при проверке
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentSHCenter.Name_shopping_center))
                errors.AppendLine("Укажите название ТЦ");
            if (_currentSHCenter.Quantity_pavilions == null)
                errors.AppendLine("Выберите код поставщика");
            if (_currentSHCenter.City == null)
                errors.AppendLine("Укажите город");
            if (_currentSHCenter.Price == 0)
                errors.AppendLine("Укажите цену");
            if (_currentSHCenter.Coeff_add_price == 0)
                errors.AppendLine("Укажите коэфф. добавочной стоимости");
            if (_currentSHCenter.Number_floors < 0)
                errors.AppendLine("Укажите этажность");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            // еще не присвоен код нов товара. 
            if (_currentSHCenter.id_shopping_center > 1) // пытается добавить экземпляр нового тц
                ShoppingCenterEntities.GetContext().Shopping_centers.Add(_currentSHCenter);

            try// блок try catch для безопасного сохранения
            {
                ShoppingCenterEntities.GetContext().SaveChanges();
                MessageBox.Show("Успешно сохранено!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnPavilions_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PavilionsPage(_currentSHCenter));
        }

        private void BtnSaveEdit_Click(object sender, RoutedEventArgs e)
        { // sb для хранения ошибок при проверке
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentSHCenter.Name_shopping_center))
                errors.AppendLine("Укажите название ТЦ");
            if (_currentSHCenter.Quantity_pavilions == null)
                errors.AppendLine("Выберите код поставщика");
            if (_currentSHCenter.City == null)
                errors.AppendLine("Укажите город");
            if (_currentSHCenter.Price == 0)
                errors.AppendLine("Укажите цену");
            if (_currentSHCenter.Coeff_add_price == 0)
                errors.AppendLine("Укажите коэфф. добавочной стоимости");
            if (_currentSHCenter.Number_floors < 0)
                errors.AppendLine("Укажите этажность");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            // еще не присвоен код нов товара. 
            //if (_currentSHCenter.id_shopping_center > 1) // пытается добавить экземпляр нового тц
            //ShoppingCenterEntities.GetContext().Shopping_centers.Add(_currentSHCenter);

            try// блок try catch для безопасного сохранения
            {
                ShoppingCenterEntities.GetContext().SaveChanges();
                MessageBox.Show("Успешно сохранено!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
//        private void BtnPavilions_Click(object sender, RoutedEventArgs e)
//        {
//            Manager.MainFrame.Navigate(new PavilionsPage());
//        }
//    }
//}
