using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.ProductRepo
{
    public interface IProductGetRepository
    {
        Task<IEnumerable<Product>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<Product> getSingleItem(int id);
    }
}
