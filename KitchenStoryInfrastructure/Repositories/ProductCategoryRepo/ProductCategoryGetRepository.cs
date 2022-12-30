
using KitchenStoryCore.Repository.ProductCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.ProductCategoryRepo
{

    public class ProductCategoryGetRepository : IProductCategoryGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public ProductCategoryGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<ProductCategory>> getAllItem()
        {
            IEnumerable<ProductCategory> ProductCategoryList = new List<ProductCategory>();
            ProductCategoryList = await KitchenStory_DbContext.productCategories.ToListAsync<ProductCategory>();
            return ProductCategoryList;
        }

        public ProductCategory getSingleItem(int id)
        {
            ProductCategory ProductCategory = KitchenStory_DbContext.productCategories.First(p => p.ProductCategoryId == id);



            return ProductCategory;
        }
        //public List<ProductCategory> GetProductCategories()
        //{

        //    List<ProductCategory> prodCatList = this.KitchenStory_DbContext.ProductCategories.FromSqlRaw("exec  [dbo].[Get_ProductCategory] ").ToList();
        //    return prodCatList;
        //}
    }


}
