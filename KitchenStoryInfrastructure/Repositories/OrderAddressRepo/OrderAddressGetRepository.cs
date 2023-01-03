
using KitchenStoryCore.Repository.OrderAddressRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.OrderAddressRepo
{

    public class OrderAddressGetRepository : IOrderAddressGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public OrderAddressGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<OrderAddress>> getAllItem()
        {
            IEnumerable<OrderAddress> OrderAddressList = new List<OrderAddress>();
            OrderAddressList = await KitchenStory_DbContext.OrderAddresss.Include(x=> x.Order).ToListAsync<OrderAddress>();
            return OrderAddressList;
        }

        public async Task<OrderAddress> getSingleItem(int id)
        {
            OrderAddress OrderAddress = await KitchenStory_DbContext.OrderAddresss.Include(x => x.Order).FirstAsync<OrderAddress>(p => p.OrderAddressId == id);
            return OrderAddress;
        }
        //public List<OrderAddress> GetOrderAddressCategories()
        //{

        //    List<OrderAddress> prodCatList = this.KitchenStory_DbContext.OrderAddressCategories.FromSqlRaw("exec  [dbo].[Get_OrderAddress] ").ToList();
        //    return prodCatList;
        //}
    }


}
