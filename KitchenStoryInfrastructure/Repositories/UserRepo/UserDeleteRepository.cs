using KitchenStoryCore.Repository.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.UserRepo
{
    public class UserDeleteRepository : IUserDeleteRepository
    {
        KitchenStory_UserDBContext kitchenStoryDb_Context;
        public UserDeleteRepository(KitchenStory_UserDBContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(User targetUser)
        {
            try
            {

                //User targetUser = getSingleItem(UserId);
                if (targetUser != null)
                {

                    kitchenStoryDb_Context.Users.Remove(targetUser);
                    kitchenStoryDb_Context.SaveChanges();


                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
