using System.Collections.ObjectModel;
using System.Configuration;
using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Services
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

        public async Task<ObservableCollection<string>> GetValues()
        {
            return await base.Get<ObservableCollection<string>>(ConfigurationManager.AppSettings.Get("TestValues"));
        }


    }
}
