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

namespace Client.Pages
{
    /// <summary>
    /// Interaction logic for LogOutPage.xaml
    /// </summary>
    public partial class LogOutPage : UserControl
    {
        public LogOutPage()
        {
            InitializeComponent();

            //restarting the app
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
            //Application.Current.MainWindow.Close();
            // Application.Current.
            //  MainWindow main = Application.Current.MainWindow as MainWindow;
            // main.Close();
            //GuestWindow newGuestWindow = new GuestWindow();
           // newGuestWindow.Show();

        }
    }
}
