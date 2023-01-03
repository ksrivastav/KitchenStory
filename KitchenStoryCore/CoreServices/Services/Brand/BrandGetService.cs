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
    public class BrandGetService : IBrandGetService
    {
        IBrandGetRepository prodCatGetRepository;
        ILogger<BrandGetService> logger;
        DbContextOptions options;

        public BrandGetService(DbContextOptions options, ILogger<BrandGetService> logger, IBrandGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<Brand>> getAllItem()
        {

            logger.LogInformation("Brand categosry service getAllItem");
            IEnumerable<Brand> BrandList = await prodCatGetRepository.getAllItem();
            return BrandList;

        }
        public async Task<Brand> getSingleItem(int id)
        {
            Brand Brand = await prodCatGetRepository.getSingleItem(id);

            return Brand;
        }

    }
}
