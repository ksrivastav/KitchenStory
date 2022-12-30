using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts
{
    public interface IProductCategoryGetService
    {
        Task<IEnumerable<ProductCategory>> getAllItem();
        //T getSingleItem(string a, string b);

        ProductCategory getSingleItem(int id);


    }
}
