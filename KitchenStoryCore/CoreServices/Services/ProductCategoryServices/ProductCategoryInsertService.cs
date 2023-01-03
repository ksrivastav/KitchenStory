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
    public class ProductCategoryInsertService : IProductCategoryInsertService
    {
        IProductCategoryInsertRepository prodCatInsertRepository;
        private readonly ILogger<ProductCategoryInsertService> logger;
        DbContextOptions options;

        public ProductCategoryInsertService(DbContextOptions options, ILogger<ProductCategoryInsertService> logger, IProductCategoryInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<ProductCategory> InsertAllItem()
        //{

        //    this.logger.LogInformation("Product categosry service InsertAllItem");
        //    List<ProductCategory> ProductCategoryList = this.prodCatInsertRepository.InsertAllItem();
        //    return ProductCategoryList;

        //}

        public async Task<int> insertSingleItem(ProductCategory ProductCategory)
        {
            int id = await prodCatInsertRepository.insertSingleItem(ProductCategory);
            return id;
        }


    }
}
