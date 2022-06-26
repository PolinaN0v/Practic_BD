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
    /// Логика взаимодействия для AddRentersPage.xaml
    /// </summary>
    public partial class AddRentersPage : Page
    {
        private Renters _currentRenter = new Renters();

        public AddRentersPage(Renters selectedRenter)
        {
            InitializeComponent();

            if (selectedRenter != null)
                _currentRenter = selectedRenter;

            DataContext = _currentRenter;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        { // sb для хранения ошибок при проверке
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentRenter.Name_renter))
                errors.AppendLine("Укажите имя арендатора");

            if (_currentRenter.Address == null)
                errors.AppendLine("Укажите адрес");
            if (_currentRenter.Additional_info == null)
                errors.AppendLine("Укажите доп. информацию");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            // еще не присвоен код нов товара. 
            if (_currentRenter.id_renter > 1) // пытается добавить экземпляр нового тц
                ShoppingCenterEntities.GetContext().Renters.Add(_currentRenter);

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

        private void BtnSaveEdit_Click(object sender, RoutedEventArgs e)
        { // sb для хранения ошибок при проверке
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentRenter.Name_renter))
                errors.AppendLine("Укажите имя арендатора");

            if (_currentRenter.Address == null)
                errors.AppendLine("Укажите адрес");
            if (_currentRenter.Additional_info == null)
                errors.AppendLine("Укажите доп. информацию");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }


            // еще не присвоен код нов товара. 
            //if (_currentRenter.id_renter > 1) // пытается добавить экземпляр нового тц
                //ShoppingCenterEntities.GetContext().Renters.Add(_currentRenter);

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
