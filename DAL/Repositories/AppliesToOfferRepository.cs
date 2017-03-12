using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
   public class AppliesToOfferRepository : EFRepository<AppliesToOffer>, IAppliesToOfferRepository
    {
       public AppliesToOfferRepository(IDbContext dbContext) : base(dbContext)
       {
       }

       public AppliesToOffer getAppliesToOfferByTwoId(string usrId, int ofId)
       {
           return DbSet.FirstOrDefault(x => x.OfferId == ofId && x.UserId == usrId);
       }
    }
}
