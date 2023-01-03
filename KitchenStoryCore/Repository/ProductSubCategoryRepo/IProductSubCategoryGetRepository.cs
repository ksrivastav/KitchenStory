using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductSubCategoryRepo
{
    public interface IProductSubCategoryGetRepository
    {
        Task<IEnumerable<ProductSubCategory>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<ProductSubCategory> getSingleItem(int id);
    }
}
