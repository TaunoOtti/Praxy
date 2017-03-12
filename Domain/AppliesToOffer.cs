using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AppliesToOffer
    {
        public int AppliesToOfferId { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int OfferId { get; set; }
        public virtual Offer Offer { get; set; }

        public virtual List<UsersInContract> UsersInContract { get; set; }
    }
}
