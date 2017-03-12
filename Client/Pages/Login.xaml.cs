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
using Client.Models;
using Client.Services;
using Client.ViewModels;

namespace Client.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        private AccountViewModel _vm;

        public Login()
        {
            InitializeComponent();
            _vm = new AccountViewModel();


        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();

            _vm.Login(emailLogin.Text, passwordLogin.Password);

            if (Token.getToken() != "")
            { 
                GuestWindow guest = Application.Current.MainWindow as GuestWindow;
                guest.Close();
                mw.Show();
            }
           

        }
    }
}
