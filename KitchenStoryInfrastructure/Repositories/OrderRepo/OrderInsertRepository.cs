
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
    public class OrderInsertRepository : IOrderInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.Order Order)
        {
            kitchenStoryDb_Context.Orders.Add(Order);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
