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

namespace stomatolog
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
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Window1 win=new Window1();
            win.Show();
            //// Получите введенные логин и пароль
            //string username = txtUser.Text;
            //string password = txtPass.Password;

            //// Здесь вы можете выполнить проверку логина и пароля.
            //// В этом примере допустимый логин и пароль - "admin"
            //if (IsValidLogin(username) && IsValidPassword(password))
            //{
            //    MessageBox.Show("Вход выполнен успешно!");
            //    Menu secondWindow = new Menu();

            //    secondWindow.Show();

            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Неверный логин или пароль. Попробуйте еще раз.");
            //}
        }

        // Метод для проверки логина
        private bool IsValidLogin(string username)
        {
            return username == "admin";
        }

        // Метод для проверки пароля
        private bool IsValidPassword(string password)
        {
            return password == "password";
        }

    }
}
