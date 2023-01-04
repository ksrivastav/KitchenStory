using KitchenStoryCore.Repository.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace KitchenStoryInfrastructure.Repositories.UserRepo
{
    public class UserAuthenticateRepository : IUserAuthenticateRepository
    {
        KitchenStory_UserDBContext kitchenStoryDb_Context;
        UserManager<User> userManager;
        RoleManager<IdentityRole> roleManager;
        SignInManager<User> _signInManager;
        public UserAuthenticateRepository(KitchenStory_UserDBContext kitchenStoryDb_Context, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> _signInManager)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this._signInManager = _signInManager;
        }


        public async Task<UserLogin> authenticate(string userEmail, string Password)
        {
            UserLogin userLogin = new UserLogin();
            try
            {

                userLogin.user = await userManager.FindByEmailAsync(userEmail);
                User userLogedIn = userLogin.user;
                var signInresult = await this._signInManager.PasswordSignInAsync(userLogedIn.UserName, Password, true, true);
                //signInresult = await this._signInManager.PasswordSignInAsync(userLogedIn.NormalizedUserName, Password, true, true);


                // if (userLogin.user.PasswordHash.Equals(Crypto.Password))
                if (signInresult.Succeeded)
                {
                    IList<string> identityRoles = await userManager.GetRolesAsync(userLogedIn);
                    userLogin.Roles = identityRoles;
                    return userLogin;

                }
                else
                {
                    return null;
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }


        }

        public  bool logout(string userEmail)
        {
              this._signInManager.SignOutAsync();

            return (true);
        }

    

    }
}
