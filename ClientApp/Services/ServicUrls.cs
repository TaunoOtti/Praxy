using System.Configuration;

namespace ClientApp.Services
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





    }
}
