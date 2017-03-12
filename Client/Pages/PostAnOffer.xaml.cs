using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for PostAnOffer.xaml
    /// </summary>
    public partial class PostAnOffer : UserControl
    {
        //private ObservableCollection<OfferCategory> _categories;
        private OfferViewModel _vm;
        public PostAnOffer()
        {
            InitializeComponent();
        }



        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {
            _vm.AddNewOffer(postOfferTitle.Text, postOfferDescription.Text, postOfferLocation.Text, postOfferContact.Text,
                postOfferStart.DisplayDate, postOfferEnd.DisplayDate, "", postOfferCategory.SelectedIndex);

            MainWindow gw = new MainWindow();
            gw.LinkNavigator.Navigate(new Uri("/Pages/PostanOffer.xaml", UriKind.Relative), this);

            postOfferTitle.Clear();
            postOfferDescription.Clear();
            postOfferLocation.Clear();
            postOfferContact.Clear();
            postOfferStart.SelectedDate = null;
            postOfferEnd.SelectedDate = null;
            postOfferCategory.SelectedIndex = 0;

        }

        private void PostAnOffer_OnLoaded(object sender, RoutedEventArgs e)
        {
            _vm = new OfferViewModel();
            _vm.GetAllOfferCategorys();
            this.DataContext = this._vm;
            
        }




    }
}
