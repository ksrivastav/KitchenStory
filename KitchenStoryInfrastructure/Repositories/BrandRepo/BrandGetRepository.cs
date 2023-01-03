
using KitchenStoryCore.Repository.BrandRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.BrandRepo
{

    public class BrandGetRepository : IBrandGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public BrandGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<Brand>> getAllItem()
        {
            IEnumerable<Brand> BrandList = new List<Brand>();
            BrandList = await KitchenStory_DbContext.Brands.ToListAsync<Brand>();
            return BrandList;
        }

        public async Task<Brand> getSingleItem(int id)
        {
            Brand Brand = await KitchenStory_DbContext.Brands.FirstAsync<Brand>(p => p.BrandId == id);
            return Brand;
        }
        //public List<Brand> GetBrandCategories()
        //{

        //    List<Brand> prodCatList = this.KitchenStory_DbContext.BrandCategories.FromSqlRaw("exec  [dbo].[Get_Brand] ").ToList();
        //    return prodCatList;
        //}
    }


}
