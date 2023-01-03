

using KitchenStoryCore.Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;

namespace KitchenStoryInfrastructure.Repositories.ProductRepo
{
    public class ProductUpdateRepository : IProductUpdateRepository
    {
        KitchenStory_DbContext kitchenStoryDb_Context;
        public ProductUpdateRepository(KitchenStory_DbContext kitchenStoryDb_Context)
        {

            this.kitchenStoryDb_Context = kitchenStoryDb_Context;
        }

        public async Task<Product> updateSingleItem(Product Product, IProductGetRepository ProductGetRepository)
        {
            try
            {

                Product updatedProduct = await ProductGetRepository.getSingleItem(Product.ProductId);
                if (updatedProduct != null)
                {
                    updatedProduct.Name = Product.Name;
                    updatedProduct.Price = Product.Price;
                    updatedProduct.Gender = Product.Gender;
                    updatedProduct.brand = Product.brand;
                    updatedProduct.Image = Product.Image;
                    updatedProduct.Color = Product.Color;
                    kitchenStoryDb_Context.SaveChanges();
                    updatedProduct = await ProductGetRepository.getSingleItem(Product.ProductId);
                    return updatedProduct;
                }
                else
                {
                    return Product;
                }

            }
            catch (Exception e)
            {
                return Product;
            }



        }
    }
}
