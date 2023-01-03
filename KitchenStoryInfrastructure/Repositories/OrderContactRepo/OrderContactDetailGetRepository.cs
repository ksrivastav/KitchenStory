
using KitchenStoryCore.Repository.OrderContactDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.OrderContactDetailRepo
{

    public class OrderContactDetailGetRepository : IOrderContactDetailGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public OrderContactDetailGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<OrderContactDetail>> getAllItem()
        {
            IEnumerable<OrderContactDetail> OrderContactDetailList = new List<OrderContactDetail>();
            OrderContactDetailList = await KitchenStory_DbContext.OrderContactDetails.Include(x=> x.Order).ToListAsync<OrderContactDetail>();
            return OrderContactDetailList;
        }

        public async Task<OrderContactDetail> getSingleItem(int id)
        {
            OrderContactDetail OrderContactDetail = await KitchenStory_DbContext.OrderContactDetails.Include(x => x.Order).FirstAsync<OrderContactDetail>(p => p.OrderContactDetailId == id);
            return OrderContactDetail;
        }
        //public List<OrderContactDetail> GetOrderContactDetailCategories()
        //{

        //    List<OrderContactDetail> prodCatList = this.KitchenStory_DbContext.OrderContactDetailCategories.FromSqlRaw("exec  [dbo].[Get_OrderContactDetail] ").ToList();
        //    return prodCatList;
        //}
    }


}
