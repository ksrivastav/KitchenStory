using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenStoryCore.Repository.ProductCategoryRepo
{
    public interface IProductCategoryDeleteRepository
    {
        void deleteSingleItem(DomainModel.ProductCategory targetProductCategory);


    }
}
