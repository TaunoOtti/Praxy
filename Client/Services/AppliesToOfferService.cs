using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Services
{
    public class AppliesToOfferService : BaseService
    {
        public AppliesToOfferService() : base(ServicUrls.AppliesToOfferUrl)
        {
        }

        public async Task<AppliesToOffer> AddApplieToOffer(AppliesToOffer apl)
        {
            return await base.Post("", apl);
        }
    }
}
