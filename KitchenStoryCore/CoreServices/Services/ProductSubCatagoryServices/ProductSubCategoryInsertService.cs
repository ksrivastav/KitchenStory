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
    public class ProductSubCategoryInsertService : IProductSubCategoryInsertService
    {
        IProductSubCategoryInsertRepository prodSubCatInsertRepository;
        private readonly ILogger<ProductSubCategoryInsertService> logger;
        DbContextOptions options;

        public ProductSubCategoryInsertService(DbContextOptions options, ILogger<ProductSubCategoryInsertService> logger, IProductSubCategoryInsertRepository prodSubCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodSubCatInsertRepository = prodSubCatInsertRepository;

        }
        //public List<ProductSubCategory> InsertAllItem()
        //{

        //    this.logger.LogInformation("Product categosry service InsertAllItem");
        //    List<ProductSubCategory> ProductSubCategoryList = this.prodCatInsertRepository.InsertAllItem();
        //    return ProductSubCategoryList;

        //}

        public async Task<int> insertSingleItem(ProductSubCategory ProductSubCategory)
        {
            int id = await prodSubCatInsertRepository.insertSingleItem(ProductSubCategory);
            return id;
        }


    }
}
