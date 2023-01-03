

using KitchenStoryCore.Repository.OrderDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.OrderDetailRepo
{
    public class OrderDetailUpdateRepository : IOrderDetailUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderDetailUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<OrderDetail> updateSingleItem(OrderDetail OrderDetail, IOrderDetailGetRepository OrderDetailGetRepository)
        {
            try
            {

                OrderDetail updatedOrderDetail = await OrderDetailGetRepository.getSingleItem(OrderDetail.OrderDetailId);
                if (updatedOrderDetail != null)
                {
                    updatedOrderDetail = OrderDetail;
                    //updatedOrderDetail.Name = OrderDetail.Name;
                    //updatedOrderDetail.Price = OrderDetail.Price;
                    //updatedOrderDetail.Gender = OrderDetail.Gender;
                    //updatedOrderDetail.brand = OrderDetail.brand;
                    //updatedOrderDetail.Image = OrderDetail.Image;
                    //updatedOrderDetail.Color = OrderDetail.Color;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedOrderDetail = await OrderDetailGetRepository.getSingleItem(OrderDetail.OrderDetailId);
                    return updatedOrderDetail;
                }
                else
                {
                    return OrderDetail;
                }

            }
            catch (Exception e)
            {
                return OrderDetail;
            }



        }
    }
}
