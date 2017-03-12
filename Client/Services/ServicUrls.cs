using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    public class ServicUrls
    {
        private static string getUrl(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string CvServiceUrl => getUrl("CvServiceUrl");
        public static string OfferServiceUrl => getUrl("OfferServiceUrl");
        public static string RegisterUrl => getUrl("RegisterUrl");
        public static string LoginUrl => getUrl("LoginUrl");
        public static string TestValues => getUrl("TestValues");
        public static string OfferCategoryUrl => getUrl("OfferCategoryUrl");
        public static string UserUrl => getUrl("UserUrl");
        public static string AppliesToOfferUrl => getUrl("AppliesToOfferUrl");

    }
}
