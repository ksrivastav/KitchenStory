using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.BrandRepo
{
    public interface IBrandUpdateRepository
    {
        Task<Brand> updateSingleItem(Brand Brand, IBrandGetRepository BrandGetRepository);


    }
}
