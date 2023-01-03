

using KitchenStoryCore.Repository.BrandRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.BrandRepo
{
    public class BrandUpdateRepository : IBrandUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public BrandUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<Brand> updateSingleItem(Brand Brand, IBrandGetRepository BrandGetRepository)
        {
            try
            {

                Brand updatedBrand = await BrandGetRepository.getSingleItem(Brand.BrandId);
                if (updatedBrand != null)
                {
                    updatedBrand.Name = Brand.Name;
                    updatedBrand.isActiveFlag = Brand.isActiveFlag;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedBrand = await BrandGetRepository.getSingleItem(Brand.BrandId);
                    return updatedBrand;
                }
                else
                {
                    return Brand;
                }

            }
            catch (Exception e)
            {
                return Brand;
            }



        }
    }
}
