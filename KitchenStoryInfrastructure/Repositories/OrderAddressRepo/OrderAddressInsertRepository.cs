
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
    public class OrderAddressInsertRepository : IOrderAddressInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderAddressInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.OrderAddress OrderAddress)
        {
            kitchenStoryDb_Context.OrderAddresss.Add(OrderAddress);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
