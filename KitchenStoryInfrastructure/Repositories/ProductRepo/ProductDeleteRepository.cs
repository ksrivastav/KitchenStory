using KitchenStoryCore.Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryInfrastructure.Data.DbContexts;
using KitchenStoryCore.DomainModel;



namespace KitchenStoryInfrastructure.Repositories.ProductRepo
{
    public class ProductDeleteRepository : IProductDeleteRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductDeleteRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }


        public void deleteSingleItem(Product targetProduct)
        {
            try
            {

                //Product targetProduct = getSingleItem(ProductId);
                if (targetProduct != null)
                {

                    kitchenStoryDb_Context.products.Remove(targetProduct);
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
