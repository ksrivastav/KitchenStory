using KitchenStoryCore.Repository.ProductSubCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.ProductSubCategoryContracts;

namespace KitchenStoryCore.CoreServices.Services.ProductSubCatagoryServices
{
    public class ProductSubCategoryUpdateService : IProductSubCategoryUpdateService
    {
        IProductSubCategoryUpdateRepository prodCatUpdateRepository;
        IProductSubCategoryGetRepository prodCatGetRepository;
        //ILogger<ProductSubCategoryUpdateService> logger;
        DbContextOptions options;

        public ProductSubCategoryUpdateService(DbContextOptions options, IProductSubCategoryUpdateRepository prodCatUpdateRepository, IProductSubCategoryGetRepository ProductSubCategoryGetRepository)
        {
            this.options = options;

            this.prodCatUpdateRepository = prodCatUpdateRepository;
            prodCatGetRepository = ProductSubCategoryGetRepository;

        }


        public async Task<ProductSubCategory> updateSingleItem(ProductSubCategory updatedProductSubCategory)
        {
            ProductSubCategory updatedProdCat = await prodCatUpdateRepository.updateSingleItem(updatedProductSubCategory, prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
