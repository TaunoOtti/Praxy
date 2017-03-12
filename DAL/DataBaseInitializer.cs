using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL
{
    public class DataBaseInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            var autoDetectChangesEnabled = context.Configuration.AutoDetectChangesEnabled;
            // much-much faster for bulk inserts!!!!
            context.Configuration.AutoDetectChangesEnabled = false;

            SeedFirstData(context);

            context.Configuration.AutoDetectChangesEnabled = autoDetectChangesEnabled;

            base.Seed(context);
        }

        private void SeedFirstData(ApplicationDbContext context)
        {
            context.Roles.Add(new IdentityRole("Admin"));
            context.SaveChanges();
            var userId = string.Empty;

            var manager = new ApplicationUserManager(new UserStore<User>(context));
            var testUser = new User
            {
                UserName = "admin",
                CreatedOn=DateTime.Now,
                Email = "admin@admin.ee",
                FirstName = "Super",
                LastName = "User"
               
            };
            manager.Create(testUser, "!AdminAdmin82");
          
            userId = testUser.Id;
            context.SaveChanges();
            manager.AddToRole(userId, "Admin");
            context.SaveChanges();


        }
    }
}
