using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.Repository.ProductCategoryRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;


namespace KitchenStoryCore.CoreServices.Services.ProductCategoryServices
{
    public class ProductCategoryGetService : IProductCategoryGetService
    {
        IProductCategoryGetRepository prodCatGetRepository;
        ILogger<ProductCategoryGetService> logger;
        DbContextOptions options;

        public ProductCategoryGetService(DbContextOptions options, ILogger<ProductCategoryGetService> logger, IProductCategoryGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<ProductCategory>> getAllItem()
        {

            logger.LogInformation("Product categosry service getAllItem");
            IEnumerable<ProductCategory> ProductCategoryList = await prodCatGetRepository.getAllItem();
            return ProductCategoryList;

        }
        public ProductCategory getSingleItem(int id)
        {
            ProductCategory productCategory = prodCatGetRepository.getSingleItem(id);

            return productCategory;
        }

    }
}
