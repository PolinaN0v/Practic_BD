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
    /// Логика взаимодействия для AddPavilionsPage.xaml
    /// </summary>
    public partial class AddPavilionsPage : Page
    {
        private Pavilions _currentPavilion = new Pavilions();

        public AddPavilionsPage()
        {
            InitializeComponent();
            DataContext = _currentPavilion;
            ComboIDSHCenter.ItemsSource = ShoppingCenterEntities.GetContext().Shopping_centers.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        { // sb для хранения ошибок при проверке
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentPavilion.Status))
                errors.AppendLine("Укажите статус");
            if (_currentPavilion.Floor == 0)
                errors.AppendLine("Укажите этаж");
            if (_currentPavilion.Area == 0)
                errors.AppendLine("Укажите площадь");
            if (_currentPavilion.Price_square_meter < 0)
                errors.AppendLine("Укажите цену за кв. метр");
            if (_currentPavilion.Coeff_add_price < 0)
                errors.AppendLine("Укажите коэфф. добавочной стоимости");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            // еще не присвоен код нов товара. 
            if (_currentPavilion.id_shopping_center > 1) // пытается добавить экземпляр нового тц
                ShoppingCenterEntities.GetContext().Pavilions.Add(_currentPavilion);

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

            if (string.IsNullOrWhiteSpace(_currentPavilion.Status))
                errors.AppendLine("Укажите статус");
            if (_currentPavilion.Floor == 0)
                errors.AppendLine("Укажите этаж");
            if (_currentPavilion.Area == 0)
                errors.AppendLine("Укажите площадь");
            if (_currentPavilion.Price_square_meter < 0)
                errors.AppendLine("Укажите цену за кв. метр");
            if (_currentPavilion.Coeff_add_price < 0)
                errors.AppendLine("Укажите коэфф. добавочной стоимости");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            // еще не присвоен код нов товара. 
            //if (_currentPavilion.id_shopping_center > 1) // пытается добавить экземпляр нового тц
                //ShoppingCenterEntities.GetContext().Pavilions.Add(_currentPavilion);

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