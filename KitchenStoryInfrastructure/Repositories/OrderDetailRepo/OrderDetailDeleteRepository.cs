using KitchenStoryCore.Repository.OrderDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.OrderDetailRepo
{
    public class OrderDetailDeleteRepository : IOrderDetailDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderDetailDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(OrderDetail targetOrderDetail)
        {
            try
            {

                //OrderDetail targetOrderDetail = getSingleItem(OrderDetailId);
                if (targetOrderDetail != null)
                {

                    kitchenStoryDb_Context.OrderDetails.Remove(targetOrderDetail);
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
