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
    public class ProductDeleteService : IProductDeleteService
    {
        IProductDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<ProductDeleteService> logger;
        DbContextOptions options;

        public ProductDeleteService(DbContextOptions options, ILogger<ProductDeleteService> logger, IProductDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public  void deleteSingleItem(Product targetProduct)
        {
            prodCatDeleteRepository.deleteSingleItem(targetProduct);
        }


    }
}
