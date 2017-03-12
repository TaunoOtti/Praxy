using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.Models;


namespace Client.Services
{
    public class OfferService : BaseService
    {
        public OfferService() : base(ServicUrls.OfferServiceUrl)
        {

        }

        public async Task<ObservableCollection<Offer>> GetAll()
        {
            return await base.Get<ObservableCollection<Offer>>(ConfigurationManager.AppSettings.Get("OfferServiceUrl"));
        }

        public async Task<ObservableCollection<Offer>> GetOfferByCategoryId(int categoryId)
        {

            _client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token.getToken());
            var url = "http://localhost:45801/api/OfferCategory";
            HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<ObservableCollection<Offer>>();

        }
        //public async void Register(User.RegisterBindingModel usr)
        //{

        //    _client.BaseAddress = new Uri(ConfigurationManager.AppSettings.Get("RegisterUrl"));
        //    var response = await _client.PostAsJsonAsync("http://localhost:45801/api/Account/Register", usr);
        //    var o = response.Content.Headers;
        //}

        public async Task<Offer> AddOffer(Offer ofr)
        {
            return await base.Post("", ofr);
        }

      
        public async Task<ObservableCollection<string>> GetValues()
        {
            //    HttpResponseMessage response = await _client.GetAsync(url);
            //    response.EnsureSuccessStatusCode();
            //    return await response.Content.ReadAsAsync<T>();


            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token.getToken());
            var url = "http://localhost:45801/api/values";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var o = response.Content;
            return await response.Content.ReadAsAsync<ObservableCollection<string>>();

            //client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token.getToken());
            //var asd = await client.GetStringAsync(url);

            //return await client.GetAsync(url);

            //return await base.Get<ObservableCollection<string>>(ConfigurationManager.AppSettings.Get("TestValues"));
        }




    }
}
