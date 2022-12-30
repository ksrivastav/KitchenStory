

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
    public class ProductCategoryUpdateRepository : IProductCategoryUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductCategoryUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public ProductCategory updateSingleItem(ProductCategory ProductCategory, IProductCategoryGetRepository productCategoryGetRepository)
        {
            try
            {

                ProductCategory updatedProductCategory = productCategoryGetRepository.getSingleItem(ProductCategory.ProductCategoryId);
                if (updatedProductCategory != null)
                {
                    updatedProductCategory.Name = ProductCategory.Name;
                    updatedProductCategory.tags = ProductCategory.tags;
                    updatedProductCategory.Description = ProductCategory.Description;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedProductCategory = productCategoryGetRepository.getSingleItem(ProductCategory.ProductCategoryId);
                    return updatedProductCategory;
                }
                else
                {
                    return ProductCategory;
                }

            }
            catch (Exception e)
            {
                return ProductCategory;
            }



        }
    }
}
