using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductSubCategoryRepo
{
    public interface IProductSubCategoryInsertRepository
    {
         Task<int> insertSingleItem(ProductSubCategory ProductSubCategory);

    }
}
