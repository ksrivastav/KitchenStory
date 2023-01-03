using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductRepo
{
    public interface IProductInsertRepository
    {
         Task<int> insertSingleItem(Product Product);

    }
}
