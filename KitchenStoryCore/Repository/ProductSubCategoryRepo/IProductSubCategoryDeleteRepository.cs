using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenStoryCore.Repository.ProductSubCategoryRepo
{
    public interface IProductSubCategoryDeleteRepository
    {
        void deleteSingleItem(DomainModel.ProductSubCategory targetProductSubCategory);


    }
}
