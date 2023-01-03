
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
    public class OrderDetailInsertRepository : IOrderDetailInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderDetailInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.OrderDetail OrderDetail)
        {
            kitchenStoryDb_Context.OrderDetails.Add(OrderDetail);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
