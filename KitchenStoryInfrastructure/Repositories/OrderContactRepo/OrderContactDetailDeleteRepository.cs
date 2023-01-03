using KitchenStoryCore.Repository.OrderContactDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.OrderContactDetailRepo
{
    public class OrderContactDetailDeleteRepository : IOrderContactDetailDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderContactDetailDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(OrderContactDetail targetOrderContactDetail)
        {
            try
            {

                //OrderContactDetail targetOrderContactDetail = getSingleItem(OrderContactDetailId);
                if (targetOrderContactDetail != null)
                {

                    kitchenStoryDb_Context.OrderContactDetails.Remove(targetOrderContactDetail);
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
