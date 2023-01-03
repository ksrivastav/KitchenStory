using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.CoreServices.Contracts.ProductSubCategoryContracts
{
    public interface IProductSubCategoryGetService
    {
        Task<IEnumerable<ProductSubCategory>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<ProductSubCategory> getSingleItem(int id);


    }
}
