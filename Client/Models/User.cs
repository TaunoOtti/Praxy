using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Client.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public DateTime CreatedOn { get; set; }

        public virtual List<Cv> Cvs { get; set; }

        public virtual List<Offer> Offers { get; set; }

        public virtual List<AppliesToOffer> AppliesToOffers { get; set; }

        public virtual List<UsersInContract> UsersInContracts { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public class RegisterBindingModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }

        public class LoginBindingModel
        {
            public string grant_type { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

        }
    }
}
