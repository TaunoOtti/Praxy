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
using ClientApp.ViewModels;

namespace ClientApp.Pages
{
    /// <summary>
    /// Interaction logic for offers.xaml
    /// </summary>
    public partial class Offers : UserControl
    {
        private OfferViewModel _vm;
        public Offers()
        {
            InitializeComponent();
            _vm = new OfferViewModel();
            _vm.LoadAllOffers();
            DataContext = _vm;
        }
    }
}
