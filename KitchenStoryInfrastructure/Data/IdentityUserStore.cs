using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using KitchenStoryInfrastructure.Data;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryCore.DomainModel
{
    public class IdentityUserStore:UserStore<User>
    {
        public IdentityUserStore(KitchenStory_UserDBContext dbContext):base(dbContext)
        {

        }
    }
}
