
using KitchenStoryCore.Repository.OrderRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.OrderRepo
{

    public class OrderGetRepository : IOrderGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public OrderGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<Order>> getAllItem()
        {
            IEnumerable<Order> OrderList = new List<Order>();
            OrderList = await KitchenStory_DbContext.Orders.ToListAsync<Order>();
            return OrderList;
        }

        public async Task<Order> getSingleItem(int id)
        {
            Order Order = await KitchenStory_DbContext.Orders.FirstAsync<Order>(p => p.OrderId == id);
            return Order;
        }
        //public List<Order> GetOrderCategories()
        //{

        //    List<Order> prodCatList = this.KitchenStory_DbContext.OrderCategories.FromSqlRaw("exec  [dbo].[Get_Order] ").ToList();
        //    return prodCatList;
        //}
    }


}
