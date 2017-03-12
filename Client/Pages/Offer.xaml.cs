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
    /// Interaction logic for Offer.xaml
    /// </summary>
    public partial class Offer : UserControl
    {
        private OfferViewModel _vm;
        private Models.Offer _offer;

        public Offer()
        {
            InitializeComponent();
        }

        //public Offer(Models.Offer offer)
        //{
        //    InitializeComponent();
        //    _vm = new OfferViewModel();
        //    _vm.Offer = offer;

        //}

        private void backToCategory_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.LinkNavigator.Navigate(new Uri("/Pages/OfferList.xaml", UriKind.Relative), this);
        }

        private void Offer_OnLoaded(object sender, RoutedEventArgs e)
        {
            _vm = new OfferViewModel();
            _vm.Offer = Token.getOffer();

            Title.Content = _vm.Offer.Title;
            Description.Content = _vm.Offer.Description;
            Category.Content = _vm.Offer.OfferCategory.Name;
            Contact.Content = _vm.Offer.ContactPerson;
            EndTime.Content = _vm.Offer.EndTime.Date.ToString();
            StartTime.Content = _vm.Offer.StartTime.Date.ToString();
            Location.Content = _vm.Offer.Location;
            Date.Content = _vm.Offer.OfferExpires.Date.ToString();
        }

        private void ApplyToOfferBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _vm = new OfferViewModel();
            _vm.ApplyToOffer(Token.getOffer().OfferId);
            MainWindow mw = new MainWindow();
            mw.LinkNavigator.Navigate(new Uri("/Pages/OfferList.xaml", UriKind.Relative), this);
        }
    }
}
