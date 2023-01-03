
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
    public class OrderContactDetailInsertRepository : IOrderContactDetailInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public OrderContactDetailInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.OrderContactDetail OrderContactDetail)
        {
            kitchenStoryDb_Context.OrderContactDetails.Add(OrderContactDetail);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
