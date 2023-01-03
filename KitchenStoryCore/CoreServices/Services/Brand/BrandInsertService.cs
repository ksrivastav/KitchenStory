using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.Repository.BrandRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.BrandContracts;

namespace KitchenStoryCore.CoreServices.Services.BrandServices
{
    public class BrandInsertService : IBrandInsertService
    {
        IBrandInsertRepository prodCatInsertRepository;
        private readonly ILogger<BrandInsertService> logger;
        DbContextOptions options;

        public BrandInsertService(DbContextOptions options, ILogger<BrandInsertService> logger, IBrandInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<Brand> InsertAllItem()
        //{

        //    this.logger.LogInformation("Brand categosry service InsertAllItem");
        //    List<Brand> BrandList = this.prodCatInsertRepository.InsertAllItem();
        //    return BrandList;

        //}

        public async Task<int> insertSingleItem(Brand Brand)
        {
            int id = await prodCatInsertRepository.insertSingleItem(Brand);
            return id;
        }


    }
}
