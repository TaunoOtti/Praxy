using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class AppliesToOfferFactory
    {
        public AppliesToOfferDTO CreateBasicAppliesToOfferDTO(AppliesToOffer ap)
        {
            return new AppliesToOfferDTO
            {
                AppliesToOfferId = ap.AppliesToOfferId,
                OfferId = ap.OfferId,
                Offer = ap.Offer,             
                UserId = ap.UserId,
                User = ap.User
            };
        }
    }
}
