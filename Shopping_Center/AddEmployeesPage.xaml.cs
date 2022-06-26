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
    /// Логика взаимодействия для AddEmployeesPage.xaml
    /// </summary>
    public partial class AddEmployeesPage : Page
    {
        private Emplooyes _currentEmplooye = new Emplooyes();

        public AddEmployeesPage(Emplooyes selectedEmplooye)
        {
            InitializeComponent();

            if (selectedEmplooye != null)
                _currentEmplooye = selectedEmplooye;

            DataContext = _currentEmplooye;
            ComboRole.ItemsSource = ShoppingCenterEntities.GetContext().Emplooyes.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        { // sb для хранения ошибок при проверке
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentEmplooye.Surname))
                errors.AppendLine("Укажите фамилию");
            if (_currentEmplooye.Name == null)
                errors.AppendLine("Укажите имя");
            if (_currentEmplooye.Second_name == null)
                errors.AppendLine("Укажите отчество");
            if (_currentEmplooye.Login == null)
                errors.AppendLine("Укажите логин");
            if (_currentEmplooye.Password == null)
                errors.AppendLine("Укажите пароль");
            if (_currentEmplooye.Role == null)
                errors.AppendLine("Выберите роль");
            if (_currentEmplooye.Phone == null)
                errors.AppendLine("Укажите телефон");
            if (_currentEmplooye.Gender == null)
                errors.AppendLine("Укажите пол");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            // еще не присвоен код нов товара. 
            if (_currentEmplooye.id_emplooye > 12) // пытается добавить экземпляр нового тц
                ShoppingCenterEntities.GetContext().Emplooyes.Add(_currentEmplooye);

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

            if (string.IsNullOrWhiteSpace(_currentEmplooye.Surname))
                errors.AppendLine("Укажите фамилию");
            if (_currentEmplooye.Name == null)
                errors.AppendLine("Укажите имя");
            if (_currentEmplooye.Second_name == null)
                errors.AppendLine("Укажите отчество");
            if (_currentEmplooye.Login == null)
                errors.AppendLine("Укажите логин");
            if (_currentEmplooye.Password == null)
                errors.AppendLine("Укажите пароль");
            if (_currentEmplooye.Role == null)
                errors.AppendLine("Выберите роль");
            if (_currentEmplooye.Phone == null)
                errors.AppendLine("Укажите телефон");
            if (_currentEmplooye.Gender == null)
                errors.AppendLine("Укажите пол");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            // еще не присвоен код нов товара. 
            //if (_currentEmplooye.id_emplooye > 12) // пытается добавить экземпляр нового тц
                //ShoppingCenterEntities.GetContext().Emplooyes.Add(_currentEmplooye);

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
