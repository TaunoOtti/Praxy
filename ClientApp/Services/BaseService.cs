using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp.Services
{
    public class BaseService
    {
        private HttpClient _client;

        public BaseService(string serviceUrl)
        {
            this._client = new HttpClient();
            _client.BaseAddress = new Uri(serviceUrl);
        }

        public async Task<T> Get<T>(string url)
        {

            //_client.DefaultRequestHeaders.Add("Authorization", "Bearer" + "TOKEN");
            HttpResponseMessage response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<T>();
        }

        public async Task<T> Post<T>(string url, T obj)
        {
            var response = await _client.PostAsJsonAsync<T>(url, obj);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<T>();
        }

        public async void Update(string url, object obj)
        {
            var response = await _client.PutAsJsonAsync(url, obj);
            response.EnsureSuccessStatusCode();

        }

        public async void Delete(string url)
        {
            var response = await _client.DeleteAsync(_client.BaseAddress);
            response.EnsureSuccessStatusCode();
        }
    }
}
