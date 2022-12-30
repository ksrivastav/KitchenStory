using KitchenStoryCore.Repository.ProductCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.ProductCategoryRepo
{
    public class ProductCategoryDeleteRepository : IProductCategoryDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductCategoryDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(ProductCategory targetProductCategory)
        {
            try
            {

                //ProductCategory targetProductCategory = getSingleItem(ProductCategoryId);
                if (targetProductCategory != null)
                {

                    kitchenStoryDb_Context.productCategories.Remove(targetProductCategory);
                    kitchenStoryDb_Context.SaveChanges();


                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
