using KitchenStoryCore.Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.ProductRepo
{

    public class ProductGetRepository : IProductGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public ProductGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<Product>> getAllItem()
        {
            IEnumerable<Product> ProductList = new List<Product>();
            ProductList = await KitchenStory_DbContext.products.Include(x => x.ProductSubCategory).Include(x => x.brand).Include(x => x.ProductSubCategory.ProductCategory).ToListAsync<Product>();
            return ProductList;
        }

        public async Task<Product> getSingleItem(int id)
        {
            Product Product = await KitchenStory_DbContext.products.Include(x => x.ProductSubCategory).Include(x => x.brand).Include(x => x.ProductSubCategory.ProductCategory).FirstAsync<Product>(p => p.ProductId == id);
            return Product;
        }
        //public List<Product> GetProductCategories()
        //{

        //    List<Product> prodCatList = this.KitchenStory_DbContext.ProductCategories.FromSqlRaw("exec  [dbo].[Get_Product] ").ToList();
        //    return prodCatList;
        //}
    }


}
