
using KitchenStoryCore.Repository.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace KitchenStoryInfrastructure.Repositories.UserRepo
{

    public class UserGetRepository : IUserGetRepository
    {
        KitchenStory_UserDBContext KitchenStory_DbContext;
        UserManager<User> userManager;
        public UserGetRepository(KitchenStory_UserDBContext KitchenStory_DbContext, UserManager<User> userManager)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;
            this.userManager = userManager;

        }
        public async Task<IEnumerable<User>> getAllItem()
        {
            IEnumerable<User> UserList = new List<User>();
            //UserList = await KitchenStory_DbContext.Users.Include(x=> x.).ToListAsync<User>();
            UserList = await this.userManager.Users.ToListAsync<User>();
            return UserList;
        }

        public async Task<User> getSingleItem(string emailid )
        {
            User User = await this.userManager.FindByEmailAsync(emailid);
            //await KitchenStory_DbContext.UsersFirstAsync<User>(p => p.Id == id);
            return User;
        }
        //public List<User> GetUserCategories()
        //{

        //    List<User> prodCatList = this.KitchenStory_DbContext.UserCategories.FromSqlRaw("exec  [dbo].[Get_User] ").ToList();
        //    return prodCatList;
        //}
    }


}
