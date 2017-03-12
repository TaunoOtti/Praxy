﻿using System.Collections.Generic;

namespace Client.Models
{
   public class OfferCategory
    {
       public int OfferCategoryId { get; set; }
       public string Name { get; set; }
       public virtual List<Offer> Offers { get; set; }
    }
}
