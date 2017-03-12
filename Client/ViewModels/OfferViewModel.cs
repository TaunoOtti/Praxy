using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;
using Client.Services;

namespace Client.ViewModels
{
    public class OfferViewModel
    {
        private ObservableCollection<Offer> _offers;
        private ObservableCollection<Offer> _Sortedoffers;
        private ObservableCollection<OfferCategory> _categories;
        private OfferService _service;
        private AccountService _account;
        private AppliesToOfferService _appliesOffer;
        private OfferCategoryService _categoryService;
        private Offer _offer;

        public ObservableCollection<Offer> Offers
        {
            get { return _offers; }
            set { _offers = value; }
        }

        public ObservableCollection<Offer> SortedOffers
        {
            get { return _Sortedoffers; }
            set { _Sortedoffers = value; }
        }

        public Offer Offer
        {
            get { return _offer; }
            set { _offer = value; }
        }

        public ObservableCollection<OfferCategory> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }

        public OfferViewModel()
        {
            _service = new OfferService();
            _offers = new ObservableCollection<Offer>();
            _categories = new ObservableCollection<OfferCategory>();
            _categoryService = new OfferCategoryService();
            _appliesOffer = new AppliesToOfferService();
            _account = new AccountService();

    }

        public async void GetAllOfferCategorys()
        {
            var result = await _categoryService.GetAll();

            foreach (var cat in result)
            {
                _categories.Add(new OfferCategory
                {
                    OfferCategoryId = cat.OfferCategoryId,
                    Name = cat.Name
                });
            }
        }

        public async void GetAllOffers()
        {
            var result = await _service.GetAll();
            foreach (var offer in result)
            {
                _offers.Add(offer);
            }
        }

        public void Sort(int id)
        {
            _Sortedoffers = new ObservableCollection<Offer>();
            foreach (var offer in _offers)
            {
                if (offer.OfferCategoryId == id)
                {
                    SortedOffers.Add(offer);
                }
            }
              
        }

        public void ShowData(Offer ofr)
        {
            Offer = ofr;

        }

        public async void AddNewOffer(string title, string description, string location, string contactperson, DateTime start, DateTime end, string userId, int offercategory)
        {
            Offer ofr = new Offer
            {
                Title = title,
                Description = description,
                Location = location,
                ContactPerson = contactperson,
                StartTime = start,
                EndTime = end,
                OfferCreated = DateTime.Now,
                OfferExpires = DateTime.Now.AddDays(30),
                OfferCategoryId = offercategory+1,
                UserId = "fd2d7f99-d5a7-4a6c-a41f-2f0d0a153690"

            };
             await _service.AddOffer(ofr);
        }

        public void ApplyToOffer(int offerId)
        {
            //var usr = _account.GetUserIdbyEmail(Token.getUser());
            //User user = usr.Result;
            //_appliesOffer.AddApplieToOffer(new AppliesToOffer
            //{
            //    AppliesToOfferId = offerId,
            //});
        }

        public async void LoadWeb()
        {
            var result = await _service.GetAll();
            foreach (var item in result)
            {
                _offers.Add(new Offer
                {
                    OfferId = item.OfferId,
                    Title = item.Title,
                    Location = item.Location,
                    StartTime = item.StartTime,
                    EndTime = item.EndTime
                });
            }
        }
    }
}
