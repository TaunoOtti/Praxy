using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BLL.DTO
{
    public class UserDTO
    {
        public string UserId { get; set; }
        public string Email { get; set; }
         
    }

    public class UserFullDTO : IdentityUser
    {
        public UserFullDTO(string userName) : base(userName)
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual List<Cv> Cvs { get; set; }

        public virtual List<Offer> Offers { get; set; }

        public virtual List<AppliesToOffer> AppliesToOffers { get; set; }

        public virtual List<UsersInContract> UsersInContracts { get; set; }
    }
}
