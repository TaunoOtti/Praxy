using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class OfferCategory
    {
       public int OfferCategoryId { get; set; }
       public string Name { get; set; }
       public virtual List<Offer> Offers { get; set; }
    }
}
