using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.Repository.ProductRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.ProductContracts;


namespace KitchenStoryCore.CoreServices.Services.ProductServices
{
    public class ProductGetService : IProductGetService
    {
        IProductGetRepository prodCatGetRepository;
        ILogger<ProductGetService> logger;
        DbContextOptions options;

        public ProductGetService(DbContextOptions options, ILogger<ProductGetService> logger, IProductGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<Product>> getAllItem()
        {

            logger.LogInformation("Product categosry service getAllItem");
            IEnumerable<Product> ProductList = await prodCatGetRepository.getAllItem();
            return ProductList;

        }
        public async Task<Product> getSingleItem(int id)
        {
            Product Product = await prodCatGetRepository.getSingleItem(id);

            return Product;
        }

    }
}
