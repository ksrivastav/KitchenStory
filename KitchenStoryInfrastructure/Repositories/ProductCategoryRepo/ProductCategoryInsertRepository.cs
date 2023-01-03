
using KitchenStoryCore.Repository.ProductCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.ProductCategoryRepo
{
    public class ProductCategoryInsertRepository : IProductCategoryInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductCategoryInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.ProductCategory ProductCategory)
        {
            kitchenStoryDb_Context.productCategories.Add(ProductCategory);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
