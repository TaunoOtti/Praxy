using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using Domain;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<User>, IDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new DataBaseInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<Cv> Cvs { get; set; }
        public IDbSet<Offer> Offers { get; set; }
        public IDbSet<OfferCategory> OfferCategories { get; set; }
        public IDbSet<AppliesToOffer> AppliesToOfferss { get; set; }
        //public IDbSet<OfferContent> OfferContents { get; set; }
        //public IDbSet<OfferType> OfferTypes { get; set; }
        public IDbSet<UsersInContract> UsersInContracts { get; set; }
        //public IDbSet<UserType> UserTypes { get; set; }
    }
}
