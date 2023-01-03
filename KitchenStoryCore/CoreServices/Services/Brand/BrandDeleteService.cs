using KitchenStoryCore.Repository.BrandRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.BrandContracts;

namespace KitchenStoryCore.CoreServices.Services.BrandServices
{
    public class BrandDeleteService : IBrandDeleteService
    {
        IBrandDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<BrandDeleteService> logger;
        DbContextOptions options;

        public BrandDeleteService(DbContextOptions options, ILogger<BrandDeleteService> logger, IBrandDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public  void deleteSingleItem(Brand targetBrand)
        {
            prodCatDeleteRepository.deleteSingleItem(targetBrand);
        }


    }
}
