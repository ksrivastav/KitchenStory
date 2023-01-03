using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.BrandRepo
{
    public interface IBrandGetRepository
    {
        Task<IEnumerable<Brand>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<Brand> getSingleItem(int id);
    }
}
