
using KitchenStoryCore.Repository.ProductSubCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.ProductSubCategoryRepo
{
    public class ProductSubCategoryInsertRepository : IProductSubCategoryInsertRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductSubCategoryInsertRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;

        }
        public async Task<int> insertSingleItem(KitchenStoryCore.DomainModel.ProductSubCategory ProductSubCategory)
        {
            kitchenStoryDb_Context.productSubCategories.Add(ProductSubCategory);
            int id = await kitchenStoryDb_Context.SaveChangesAsync();
            return id;
        }
    }
}
