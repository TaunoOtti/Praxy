using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public static class Token
    {
        private static string TOKEN = "";
        private static string USER = "";
        private static string USERID = "";
        private static Offer OFFER;

        public static void setToken(string token)
        {
            TOKEN = token;
        }
        public static string getToken() 
        {
            return TOKEN;
        }

        public static void setUser(string username)
        {
            USER = username;
        }
        public static string getUser()
        {
            return USER;
        }

        public static void setUserId(string id)
        {
            USERID = id;
        }
        public static string getUserId()
        {
            return USERID;
        }

        public static void setOffer(Offer ofr)
        {
            OFFER = ofr;
        }
        public static Offer getOffer()
        {
            return OFFER;
        }
    }
}
