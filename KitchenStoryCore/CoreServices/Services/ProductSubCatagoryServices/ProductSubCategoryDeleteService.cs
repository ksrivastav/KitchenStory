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
    public class ProductSubCategoryDeleteService : IProductSubCategoryDeleteService
    {
        IProductSubCategoryDeleteRepository prodSubCatDeleteRepository;
        private readonly ILogger<ProductSubCategoryDeleteService> logger;
        DbContextOptions options;

        public ProductSubCategoryDeleteService(DbContextOptions options, ILogger<ProductSubCategoryDeleteService> logger, IProductSubCategoryDeleteRepository prodSubCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodSubCatDeleteRepository = prodSubCatDeleteRepository;

        }


        public void deleteSingleItem(ProductSubCategory targetProductSubCategory)
        {
            prodSubCatDeleteRepository.deleteSingleItem(targetProductSubCategory);
        }


    }
}
