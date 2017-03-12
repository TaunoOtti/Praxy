using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using Domain;

namespace BLL.Factories
{
    public class OfferCategoryFactory
    {
        public OfferCategoryDTO CraeteBasiCategoryDTO(OfferCategory oc)
        {
            return new OfferCategoryDTO
            {
                Name = oc.Name,
                OfferCategoryId = oc.OfferCategoryId
            };
        }
    }
}
