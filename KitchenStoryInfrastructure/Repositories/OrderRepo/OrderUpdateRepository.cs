

using KitchenStoryCore.Repository.OrderRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.OrderRepo
{
    public class OrderUpdateRepository : IOrderUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<Order> updateSingleItem(Order Order, IOrderGetRepository OrderGetRepository)
        {
            try
            {

                Order updatedOrder = await OrderGetRepository.getSingleItem(Order.OrderId);
                if (updatedOrder != null)
                {
                    updatedOrder = Order;
                    //updatedOrder.Name = Order.Name;
                    //updatedOrder.Price = Order.Price;
                    //updatedOrder.Gender = Order.Gender;
                    //updatedOrder.brand = Order.brand;
                    //updatedOrder.Image = Order.Image;
                    //updatedOrder.Color = Order.Color;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedOrder = await OrderGetRepository.getSingleItem(Order.OrderId);
                    return updatedOrder;
                }
                else
                {
                    return Order;
                }

            }
            catch (Exception e)
            {
                return Order;
            }



        }
    }
}
