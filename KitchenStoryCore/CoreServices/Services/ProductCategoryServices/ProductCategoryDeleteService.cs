using KitchenStoryCore.Repository.ProductCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.CoreServices.Services.ProductCategoryServices
{
    public class ProductCategoryDeleteService
    {
        IProductCategoryDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<ProductCategoryGetService> logger;
        DbContextOptions options;

        public ProductCategoryDeleteService(DbContextOptions options, ILogger<ProductCategoryGetService> logger, IProductCategoryDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public void deleteSingleItem(ProductCategory targetProductCategory)
        {
            prodCatDeleteRepository.deleteSingleItem(targetProductCategory);
        }


    }
}
