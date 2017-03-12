using System.Collections.Generic;

namespace ClientApp.Models
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
