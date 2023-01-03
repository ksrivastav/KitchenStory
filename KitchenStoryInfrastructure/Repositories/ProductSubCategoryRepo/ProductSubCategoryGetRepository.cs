
using KitchenStoryCore.Repository.ProductSubCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.ProductSubCategoryRepo
{

    public class ProductSubCategoryGetRepository : IProductSubCategoryGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public ProductSubCategoryGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<ProductSubCategory>> getAllItem()
        {
            IEnumerable<ProductSubCategory> ProductSubCategoryList = new List<ProductSubCategory>();
            ProductSubCategoryList = await KitchenStory_DbContext.productSubCategories.Include(x=> x.ProductCategory).ToListAsync<ProductSubCategory>();
            return ProductSubCategoryList;
        }

        public async Task<ProductSubCategory> getSingleItem(int id)
        {
            ProductSubCategory ProductSubCategory = await KitchenStory_DbContext.productSubCategories.Include(x => x.ProductCategory).FirstAsync<ProductSubCategory>(p => p.ProductSubCategoryId == id);
            return ProductSubCategory;
        }
        //public List<ProductSubCategory> GetProductCategories()
        //{

        //    List<ProductSubCategory> prodCatList = this.KitchenStory_DbContext.ProductCategories.FromSqlRaw("exec  [dbo].[Get_ProductSubCategory] ").ToList();
        //    return prodCatList;
        //}
    }


}
