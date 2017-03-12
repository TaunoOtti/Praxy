using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BLL.DTO
{
    public class AppliesToOfferDTO
    {
        public int AppliesToOfferId { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int OfferId { get; set; }
        public virtual Offer Offer { get; set; }
    }
}
