using KitchenStoryCore.Repository.OrderAddressRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.OrderAddressRepo
{
    public class OrderAddressDeleteRepository : IOrderAddressDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderAddressDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(OrderAddress targetOrderAddress)
        {
            try
            {

                //OrderAddress targetOrderAddress = getSingleItem(OrderAddressId);
                if (targetOrderAddress != null)
                {

                    kitchenStoryDb_Context.OrderAddresss.Remove(targetOrderAddress);
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
