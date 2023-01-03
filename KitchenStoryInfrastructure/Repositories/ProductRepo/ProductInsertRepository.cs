
using KitchenStoryCore.Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.ProductRepo
{
    public class ProductInsertRepository : IProductInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.Product Product)
        {
            kitchenStoryDb_Context.products.Add(Product);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
