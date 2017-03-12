using System;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Services
{
    public class AccountService : BaseService
    {
        private HttpClient _client;
        //  App.Current.Properties["key"] = 5;
        public AccountService() : base(ServicUrls.RegisterUrl)
        {
            _client = new HttpClient();
        }

        public async void Register(RegisterBindingModel usr)
        {
           //HttpClient _client = new HttpClient();
            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings.Get("RegisterUrl"));

            var response = await _client.PostAsJsonAsync("http://localhost:45801/api/Account/Register", usr);
            var oss = response.Content;      
        }

        public async void Login(LoginBindingModel log)
        {
            //_client.BaseAddress = new Uri(ConfigurationManager.AppSettings.Get("LoginUrl"));

            //var response = await _client.PostAsJsonAsync("http://localhost:45801/Token", log);

        
            
            //var ewq = await _client.PostAsXmlAsync("http://localhost:45801/Token",
            //    "grant_type=" + log.grant_type + "&username=" + log.Username + "&password=" + log.Password);


            //var asd = await _client.PostAsJsonAsync("http://localhost:45801/Token", "grant_type="+log.grant_type+"&username="+log.Username+"&password="+log.Password);


            var request = (HttpWebRequest)WebRequest.Create("http://localhost:45801/Token");

            var postData = "grant_type=" + log.grant_type + "&username=" + log.Username + "&password=" + log.Password;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response1 = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response1.GetResponseStream()).ReadToEnd();

            App.Current.Properties["acccessToken"] = responseString;

            string o = (string) App.Current.Properties["accessToken"];




        }
    }
}
