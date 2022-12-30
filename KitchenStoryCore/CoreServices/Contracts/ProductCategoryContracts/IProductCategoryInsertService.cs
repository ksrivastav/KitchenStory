using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KitchenStoryCore.DomainModel;
using System.Threading.Tasks;

namespace KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts
{
    public interface IProductCategoryInsertService
    {
        int insertSingleItem(ProductCategory ProductCategory);

    }
}
