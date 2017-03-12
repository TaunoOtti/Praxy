using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Services
{
    class OfferCategoryService : BaseService
    {
        public OfferCategoryService() : base(ServicUrls.OfferCategoryUrl)
        {
        }

        public async Task<ObservableCollection<OfferCategory>> GetAll()
        {
            return await base.Get<ObservableCollection<OfferCategory>>(ConfigurationManager.AppSettings.Get("OfferCategoryUrl"));
        }
    }
}
