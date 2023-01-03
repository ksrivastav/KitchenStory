using KitchenStoryCore.Repository.ProductCategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;

namespace KitchenStoryCore.CoreServices.Services.ProductCategoryServices
{
    public class ProductCategoryUpdateService :IProductCategoryUpdateService
    {
        IProductCategoryUpdateRepository prodCatUpdateRepository;
        IProductCategoryGetRepository prodCatGetRepository;
        //ILogger<ProductCategoryUpdateService> logger;
        DbContextOptions options;

        public ProductCategoryUpdateService(DbContextOptions options, IProductCategoryUpdateRepository prodCatUpdateRepository, IProductCategoryGetRepository productCategoryGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = productCategoryGetRepository;

        }


        public async Task<ProductCategory> updateSingleItem(ProductCategory updatedProductCategory)
        {
           ProductCategory updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedProductCategory, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
