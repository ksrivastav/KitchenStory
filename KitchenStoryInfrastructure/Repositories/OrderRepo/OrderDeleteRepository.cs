using KitchenStoryCore.Repository.OrderRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.OrderRepo
{
    public class OrderDeleteRepository : IOrderDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(Order targetOrder)
        {
            try
            {

                //Order targetOrder = getSingleItem(OrderId);
                if (targetOrder != null)
                {

                    kitchenStoryDb_Context.Orders.Remove(targetOrder);
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
