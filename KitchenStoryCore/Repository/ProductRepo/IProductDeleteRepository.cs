using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenStoryCore.Repository.ProductRepo
{
    public interface IProductDeleteRepository
    {
        void deleteSingleItem(DomainModel.Product targetProduct);


    }
}
