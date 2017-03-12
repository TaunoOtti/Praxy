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
using Client.ViewModels;

namespace Client.Pages
{
    /// <summary>
    /// Interaction logic for JobOffers.xaml
    /// </summary>
    public partial class JobOffersVana : UserControl
    {
        private ObservableCollection<OfferCategory> _categories;
        private OfferViewModel _vm;
        public JobOffersVana()
        {
            InitializeComponent();
          
        }


        private void JobOffers_OnLoaded(object sender, RoutedEventArgs e)
        {
            _categories = new ObservableCollection<OfferCategory>();
            _vm = new OfferViewModel();
            _vm.GetAllOfferCategorys();
            this.DataContext = this._vm;
        }

        public static readonly DependencyProperty DisplayNameProperty =
      DependencyProperty.Register("DisplayName", typeof(string), typeof(UserControl));

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
