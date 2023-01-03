using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.Repository.ProductSubCategoryRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.ProductSubCategoryContracts;


namespace KitchenStoryCore.CoreServices.Services.ProductSubCatagoryServices
{
    public class ProductSubCategoryGetService : IProductSubCategoryGetService
    {
        IProductSubCategoryGetRepository prodSubCatGetRepository;
        ILogger<ProductSubCategoryGetService> logger;
        DbContextOptions options;

        public ProductSubCategoryGetService(DbContextOptions options, ILogger<ProductSubCategoryGetService> logger, IProductSubCategoryGetRepository prodSubCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodSubCatGetRepository = prodSubCatGetRepository;

        }
        public async Task<IEnumerable<ProductSubCategory>> getAllItem()
        {

            logger.LogInformation("Product categosry service getAllItem");
            IEnumerable<ProductSubCategory> ProductSubCategoryList = await prodSubCatGetRepository.getAllItem();
            return ProductSubCategoryList;

        }
        public async Task<ProductSubCategory> getSingleItem(int id)
        {
            ProductSubCategory productSubCategory = await prodSubCatGetRepository.getSingleItem(id);

            return productSubCategory;
        }

    }
}
