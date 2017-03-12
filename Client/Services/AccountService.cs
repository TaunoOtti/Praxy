using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Client.Models;
using Newtonsoft.Json.Linq;

namespace Client.Services
{
    public class AccountService : BaseService
    {
        private HttpClient _client;
        //  App.Current.Properties["key"] = 5;
        public AccountService() : base(ServicUrls.RegisterUrl)
        {
            _client = new HttpClient();
        }

        public async void Register(User.RegisterBindingModel usr)
        {

            _client.BaseAddress = new Uri(ConfigurationManager.AppSettings.Get("RegisterUrl"));
            var response = await _client.PostAsJsonAsync("http://localhost:45801/api/Account/Register", usr);
            var o = response.Content.Headers;
        }


        public async Task<User> GetUserIdbyEmail(string email)
        {
            var result = base.Get<User>(ConfigurationManager.AppSettings.Get("UserUrl") + "?email=" + email);
            return await result;
        }


        public async void Login(User.LoginBindingModel log)
        {
           
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


         

            JObject returnedToken = JObject.Parse(responseString);
            string token = (string) returnedToken["access_token"];
            string user = (string)returnedToken["userName"];

            var o = GetUserIdbyEmail(user);
            
            //string a = o.Result.Id;


            //Token.setUserId(o.Result.Id);
            Token.setUser(user);
            Token.setToken(token);
           


        }
      
    }
}