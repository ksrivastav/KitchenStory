
using KitchenStoryCore.Repository.BrandRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.BrandRepo
{
    public class BrandInsertRepository : IBrandInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public BrandInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.Brand Brand)
        {
            kitchenStoryDb_Context.Brands.Add(Brand);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
