using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL.DTO
{
    public class OfferSmallDTO
    {
        public int OfferId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime OfferExpires { get; set; }
    }

    public class OfferFullDTO
    {
        public int OfferId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string ContactPerson { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime OfferCreated { get; set; }
        public DateTime OfferExpires { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int OfferCategoryId { get; set; }
        public virtual OfferCategory OfferCategory { get; set; }
    }
}
