

using KitchenStoryCore.Repository.OrderContactDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.OrderContactDetailRepo
{
    public class OrderContactDetailUpdateRepository : IOrderContactDetailUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderContactDetailUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<OrderContactDetail> updateSingleItem(OrderContactDetail OrderContactDetail, IOrderContactDetailGetRepository OrderContactDetailGetRepository)
        {
            try
            {

                OrderContactDetail updatedOrderContactDetail = await OrderContactDetailGetRepository.getSingleItem(OrderContactDetail.OrderContactDetailId);
                if (updatedOrderContactDetail != null)
                {
                    updatedOrderContactDetail = OrderContactDetail;
                    //updatedOrderContactDetail.Name = OrderContactDetail.Name;
                    //updatedOrderContactDetail.Price = OrderContactDetail.Price;
                    //updatedOrderContactDetail.Gender = OrderContactDetail.Gender;
                    //updatedOrderContactDetail.brand = OrderContactDetail.brand;
                    //updatedOrderContactDetail.Image = OrderContactDetail.Image;
                    //updatedOrderContactDetail.Color = OrderContactDetail.Color;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedOrderContactDetail = await OrderContactDetailGetRepository.getSingleItem(OrderContactDetail.OrderContactDetailId);
                    return updatedOrderContactDetail;
                }
                else
                {
                    return OrderContactDetail;
                }

            }
            catch (Exception e)
            {
                return OrderContactDetail;
            }



        }
    }
}
