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
    public class ProductInsertService : IProductInsertService
    {
        IProductInsertRepository prodCatInsertRepository;
        private readonly ILogger<ProductInsertService> logger;
        DbContextOptions options;

        public ProductInsertService(DbContextOptions options, ILogger<ProductInsertService> logger, IProductInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<Product> InsertAllItem()
        //{

        //    this.logger.LogInformation("Product categosry service InsertAllItem");
        //    List<Product> ProductList = this.prodCatInsertRepository.InsertAllItem();
        //    return ProductList;

        //}

        public async Task<int> insertSingleItem(Product Product)
        {
            int id = await prodCatInsertRepository.insertSingleItem(Product);
            return id;
        }


    }
}
