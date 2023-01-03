using KitchenStoryCore.Repository.ProductSubCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.ProductSubCategoryRepo
{
    public class ProductSubCategoryDeleteRepository : IProductSubCategoryDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductSubCategoryDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(ProductSubCategory targetProductSubCategory)
        {
            try
            {

                //ProductSubCategory targetProductSubCategory = getSingleItem(ProductSubCategoryId);
                if (targetProductSubCategory != null)
                {

                    kitchenStoryDb_Context.productSubCategories.Remove(targetProductSubCategory);
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
