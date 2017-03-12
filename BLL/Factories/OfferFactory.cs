using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class OfferFactory
    {
        public OfferSmallDTO createSmallOfferDTO(Offer off)
        {
            return new OfferSmallDTO
            {
                OfferId = off.OfferId,
                Title = off.Title,
                Location = off.Location,
                OfferExpires = off.OfferExpires
            };
        }

        public OfferFullDTO createFullOfferDTO(Offer off)
        {
            return new OfferFullDTO
            {
                OfferId = off.OfferId,
                Title = off.Title,
                OfferCreated = off.OfferCreated,
                OfferExpires = off.OfferExpires,
                ContactPerson = off.ContactPerson,
                Description = off.Description,
                EndTime = off.EndTime,
                Location = off.Location,
                OfferCategoryId = off.OfferCategoryId,
                OfferCategory = off.OfferCategory,

            };
        }
    }
}
