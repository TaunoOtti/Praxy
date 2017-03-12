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
using Client.ViewModels;
using Client;
using Client.Interfaces;
using FirstFloor.ModernUI.Windows.Navigation;

namespace Client.Pages
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : UserControl
    {
        private AccountViewModel _vm;
       

        public Register()
        {
            InitializeComponent();
          

        }

       

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
  


        }

        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {
       


            _vm = new AccountViewModel();
            if (pwdReg.Password.Equals(pwdReg2.Password))
            {
                _vm.Register(emailReg.Text, pwdReg.Password, pwdReg2.Password);
                GuestWindow gw = new GuestWindow();
                gw.LinkNavigator.Navigate(new Uri("/Pages/Login.xaml", UriKind.Relative), this);
            }
            


            //Home home = new Home();
            //var a = new Home();
            //NavigationService nav;
            //nav = NavigationService.GetNavigationService(this);
            //nav.Navigate("Pages/Login.xaml");
        } 
    }
}
