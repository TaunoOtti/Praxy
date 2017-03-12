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
using Client.ViewModels;

namespace Client.Pages
{
    /// <summary>
    /// Interaction logic for OfferList.xaml
    /// </summary>
    public partial class OfferList : UserControl
    {
        private OfferViewModel _vm;
        public OfferList()
        {
            InitializeComponent();
        }

        private void OfferList_OnLoaded(object sender, RoutedEventArgs e)
        {
            _vm = new OfferViewModel();
            _vm.GetAllOffers();
            this.DataContext = _vm;
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow mv = new MainWindow();
            //Offer offer = new Offer();

            Models.Offer offers = new Models.Offer();
            offers = (Models.Offer)(sender as Hyperlink).DataContext;
            //Offer page = new Offer(offers);
            //Offer page = new Offer(offers);
            //NavigationService nav = NavigationService.GetNavigationService(this);
            //  nav.Navigate(page);
            //offer.ShowData(offers);
            //NavigationWindow nav = this.Parent as NavigationWindow;
            //nav.Navigate(page);
            Token.setOffer(offers);
            mv.LinkNavigator.Navigate(new Uri("/Pages/Offer.xaml", UriKind.Relative), this);
        }
    }
}
