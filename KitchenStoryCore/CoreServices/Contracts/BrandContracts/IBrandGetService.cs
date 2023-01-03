using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.CoreServices.Contracts.BrandContracts
{
    public interface IBrandGetService
    {
        Task<IEnumerable<Brand>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<Brand> getSingleItem(int id);


    }
}
