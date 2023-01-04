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
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace KitchenStoryInfrastructure.Repositories.UserRepo
{
    public class UserTokenHandlerRepository : IUserTokenHandlerRepository
    {
        KitchenStory_UserDBContext kitchenStoryDb_Context;
        UserManager<User> userManager;
        RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;
        public UserTokenHandlerRepository(KitchenStory_UserDBContext kitchenStoryDb_Context, IConfiguration configuration)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
            this.configuration= configuration;

        }


        public async Task<string> createTokenAsync(UserLogin targetUser)
        {

            try
            {

                List<Claim> claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.GivenName, targetUser.user.UserName));
                claims.Add(new Claim(ClaimTypes.Email, targetUser.user.Email));
                foreach (var role in targetUser.Roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));

                }

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                        configuration["Jwt:Issuer"],
                        configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.Now.AddMinutes(20),
                        signingCredentials: credential
                    );



                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                return null;
            }


                


        }
    }
}
