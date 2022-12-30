using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductCategoryRepo
{
    public interface IProductCategoryUpdateRepository
    {
        ProductCategory updateSingleItem(ProductCategory ProductCategory, IProductCategoryGetRepository productCategoryGetRepository);


    }
}
