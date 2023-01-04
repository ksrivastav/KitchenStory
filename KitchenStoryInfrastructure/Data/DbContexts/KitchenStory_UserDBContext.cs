using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace KitchenStoryInfrastructure.Data.DbContexts
{
    public class KitchenStory_UserDBContext : IdentityDbContext<User>
    {
        public KitchenStory_UserDBContext(DbContextOptions<KitchenStory_UserDBContext> dbContextOptions) : base(dbContextOptions) { 
        
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().HasData(new User { Email = "kartikayaemail", PasswordHash = "803bd65441cc811070ad7391f855454b4953cbbd5c15f4757658e32bb6377ce0" , Address="ioioio", Country="india", City="delhi"});
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Customer" });
        }
    }
}
