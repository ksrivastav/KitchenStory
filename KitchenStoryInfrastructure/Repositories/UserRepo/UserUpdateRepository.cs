

using KitchenStoryCore.Repository.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.UserRepo
{
    public class UserUpdateRepository : IUserUpdateRepository
    {
        KitchenStory_UserDBContext kitchenStoryDb_Context;
        public UserUpdateRepository(KitchenStory_UserDBContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<User> updateSingleItem(User User, IUserGetRepository UserGetRepository)
        {
            try
            {

                User updatedUser = await UserGetRepository.getSingleItem(User.Id);
                if (updatedUser != null)
                {
                    updatedUser.UserName = User.UserName;
                   // updatedUser.isActiveFlag = User.isActiveFlag;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedUser = await UserGetRepository.getSingleItem(User.Id);
                    return updatedUser;
                }
                else
                {
                    return User;
                }

            }
            catch (Exception e)
            {
                return User;
            }



        }
    }
}
