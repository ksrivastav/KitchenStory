

using KitchenStoryCore.Repository.OrderAddressRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.OrderAddressRepo
{
    public class OrderAddressUpdateRepository : IOrderAddressUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderAddressUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<OrderAddress> updateSingleItem(OrderAddress OrderAddress, IOrderAddressGetRepository OrderAddressGetRepository)
        {
            try
            {

                OrderAddress updatedOrderAddress = await OrderAddressGetRepository.getSingleItem(OrderAddress.OrderAddressId);
                if (updatedOrderAddress != null)
                {
                    updatedOrderAddress = OrderAddress;
                    //updatedOrderAddress.Name = OrderAddress.Name;
                    //updatedOrderAddress.Price = OrderAddress.Price;
                    //updatedOrderAddress.Gender = OrderAddress.Gender;
                    //updatedOrderAddress.brand = OrderAddress.brand;
                    //updatedOrderAddress.Image = OrderAddress.Image;
                    //updatedOrderAddress.Color = OrderAddress.Color;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedOrderAddress = await OrderAddressGetRepository.getSingleItem(OrderAddress.OrderAddressId);
                    return updatedOrderAddress;
                }
                else
                {
                    return OrderAddress;
                }

            }
            catch (Exception e)
            {
                return OrderAddress;
            }



        }
    }
}
