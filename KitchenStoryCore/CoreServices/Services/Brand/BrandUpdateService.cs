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
    public class BrandUpdateService :IBrandUpdateService
    {
        IBrandUpdateRepository prodCatUpdateRepository;
        IBrandGetRepository prodCatGetRepository;
        //ILogger<BrandUpdateService> logger;
        DbContextOptions options;

        public BrandUpdateService(DbContextOptions options, IBrandUpdateRepository prodCatUpdateRepository, IBrandGetRepository BrandGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = BrandGetRepository;

        }


        public async Task<Brand> updateSingleItem(Brand updatedBrand)
        {
           Brand updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedBrand, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
