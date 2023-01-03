using KitchenStoryCore.Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.ProductContracts;

namespace KitchenStoryCore.CoreServices.Services.ProductServices
{
    public class ProductUpdateService :IProductUpdateService
    {
        IProductUpdateRepository prodCatUpdateRepository;
        IProductGetRepository prodCatGetRepository;
        //ILogger<ProductUpdateService> logger;
        DbContextOptions options;

        public ProductUpdateService(DbContextOptions options, IProductUpdateRepository prodCatUpdateRepository, IProductGetRepository ProductGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = ProductGetRepository;

        }


        public async Task<Product> updateSingleItem(Product updatedProduct)
        {
           Product updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedProduct, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
