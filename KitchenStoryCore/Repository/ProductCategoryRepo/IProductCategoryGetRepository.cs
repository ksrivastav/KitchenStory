using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductCategoryRepo
{
    public interface IProductCategoryGetRepository
    {
        Task<IEnumerable<ProductCategory>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<ProductCategory> getSingleItem(int id);
    }
}
