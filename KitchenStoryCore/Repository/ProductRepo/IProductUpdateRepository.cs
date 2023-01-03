using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductRepo
{
    public interface IProductUpdateRepository
    {
        Task<Product> updateSingleItem(Product Product, IProductGetRepository ProductGetRepository);


    }
}
