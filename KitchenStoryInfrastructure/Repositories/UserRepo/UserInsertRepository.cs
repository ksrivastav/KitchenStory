
using KitchenStoryCore.Repository.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace KitchenStoryInfrastructure.Repositories.UserRepo
{
    public class UserInsertRepository : IUserInsertRepository
    {
        KitchenStory_UserDBContext kitchenStoryDb_Context;

        // IdentityUserStore appUserStore;
        //IdentityUserManager userManager;
        UserManager<User> userManager;
        RoleManager<IdentityRole> roleManager;
        public UserInsertRepository(KitchenStory_UserDBContext kitchenStoryDb_Context, UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
            //this.appUserStore = appUserStore;
            this.userManager = userManager;
            this.roleManager = roleManager;

        }
        public async Task<bool> insertSingleItem(User User,  string userRole)
        {
            IdentityResult chkUser;
            var user = await userManager.FindByEmailAsync(User.Email);
            if (user == null) 
            {

                chkUser = await userManager.CreateAsync(User);
                IdentityRole role =  this.roleManager.Roles.FirstOrDefault();
                if (chkUser.Succeeded)
                {
                    await userManager.AddToRoleAsync(User, role.Name);
                   
                }

                return chkUser.Succeeded;



            }
            else
            {
                return false;
            }
           

        }
    }
}
