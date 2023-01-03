using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductSubCategoryRepo
{
    public interface IProductSubCategoryUpdateRepository
    {
        Task<ProductSubCategory> updateSingleItem(ProductSubCategory ProductSubCategory, IProductSubCategoryGetRepository ProductSubCategoryGetRepository);


    }
}
