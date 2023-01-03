

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
    public class ProductSubCategoryUpdateRepository : IProductSubCategoryUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductSubCategoryUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<ProductSubCategory> updateSingleItem(ProductSubCategory ProductSubCategory, IProductSubCategoryGetRepository ProductSubCategoryGetRepository)
        {
            try
            {

                ProductSubCategory updatedProductSubCategory = await ProductSubCategoryGetRepository.getSingleItem(ProductSubCategory.ProductSubCategoryId);
                if (updatedProductSubCategory != null)
                {
                    updatedProductSubCategory.Name = ProductSubCategory.Name;
                    updatedProductSubCategory.tags = ProductSubCategory.tags;
                    updatedProductSubCategory.Description = ProductSubCategory.Description;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedProductSubCategory = await ProductSubCategoryGetRepository.getSingleItem(ProductSubCategory.ProductSubCategoryId);
                    return updatedProductSubCategory;
                }
                else
                {
                    return ProductSubCategory;
                }

            }
            catch (Exception e)
            {
                return ProductSubCategory;
            }



        }
    }
}
