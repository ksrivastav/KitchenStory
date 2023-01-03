using KitchenStoryCore.Repository.BrandRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.BrandRepo
{
    public class BrandDeleteRepository : IBrandDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public BrandDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(Brand targetBrand)
        {
            try
            {

                //Brand targetBrand = getSingleItem(BrandId);
                if (targetBrand != null)
                {

                    kitchenStoryDb_Context.Brands.Remove(targetBrand);
                    kitchenStoryDb_Context.SaveChanges();


                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
