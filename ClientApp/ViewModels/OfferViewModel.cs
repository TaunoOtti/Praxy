using System;
using System.Collections.ObjectModel;
using ClientApp.Models;
using ClientApp.Services;
using DAL;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ClientApp.ViewModels
{
    public class OfferViewModel
    {
        private ObservableCollection<Offer> _offers;
        private OfferService _service;
        private AccountService _aserivce;

        public ObservableCollection<Offer> Offers
        {
            get { return _offers; }
            set { _offers = value; }
        }
        public OfferViewModel()
        {
            _service = new OfferService();
            _offers = new ObservableCollection<Offer>();
            _aserivce = new AccountService();


        }

        public void LoadAllOffers()
        {
            LoadFromWeb();
            GetValues();

        }

        public async void GetValues()
        {
            var result = await _service.GetValues();
        }

        public async void LoadFromWeb()
        {
            var result = await _service.GetAll();

            //_aserivce.Register(new RegisterBindingModel
            //{
            //    Email = "123@eesti.ee",
            //    Password = "123456",
            //    ConfirmPassword = "123456"
                
            //});

            _aserivce.Login(new LoginBindingModel
            {
                grant_type = "password",
                Username = "123@eesti.ee",
                Password = "123456"
            });


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
