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
using System.IO;
using System.Diagnostics;

namespace Shopping_Center
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = "C:\\Users\\ThePi\\OneDrive\\Desktop\\BD практика\\Photos\\Emplooyes";
            var photos = Directory.EnumerateFiles(path);
            using (ShoppingCenterEntities context = new ShoppingCenterEntities())
            {
                foreach (var photo in photos)
                {
                    string s = photo.Substring(photo.LastIndexOf('\\') + 1).Split(' ')[0];
                    var employ = context.Emplooyes.Where(x => x.Surname == s).FirstOrDefault();
                    if (employ != null)
                        employ.Photo = File.ReadAllBytes(photo);
                }
                context.SaveChanges();
            }
            var path2 = "C:\\Users\\ThePi\\OneDrive\\Desktop\\BD практика\\Photos\\ShoppingCenter";
            var photos2 = Directory.EnumerateFiles(path2);
            using (ShoppingCenterEntities context = new ShoppingCenterEntities())
            {
                foreach (var photo in photos2)
                {
                    string s = photo.Substring(photo.LastIndexOf('\\') + 1);
                    string s2 = s.Substring(0, s.Length - 4);
                    var employ = context.Shopping_centers.Where(x => x.Name_shopping_center == s2).FirstOrDefault();
                    if (employ != null)
                        employ.Photo = File.ReadAllBytes(photo);
                }
                context.SaveChanges();
            }
            MessageBox.Show("Загрузка завершена");
        }

        private void BtnShoppingCenters_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ShoppingCentersPage());
            Manager.MainFrame = MainFrame;
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void BtnEmplooyes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EmplooyesPage());
            Manager.MainFrame = MainFrame;
        }

        private void BtnRenters_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RentersPage());
            Manager.MainFrame = MainFrame;
        }
    }
}
