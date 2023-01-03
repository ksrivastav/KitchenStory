
using KitchenStoryCore.Repository.OrderDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.DomainModel;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace KitchenStoryInfrastructure.Repositories.OrderDetailRepo
{

    public class OrderDetailGetRepository : IOrderDetailGetRepository
    {
        KitchenStory_DbContext KitchenStory_DbContext;

        public OrderDetailGetRepository(KitchenStory_DbContext KitchenStory_DbContext)
        {

            this.KitchenStory_DbContext = KitchenStory_DbContext;

        }
        public async Task<IEnumerable<OrderDetail>> getAllItem()
        {
            IEnumerable<OrderDetail> OrderDetailList = new List<OrderDetail>();
            OrderDetailList = await KitchenStory_DbContext.OrderDetails.Include(x => x.Product).Include(x => x.Product.brand).Include(x => x.Order).Include(x => x.Product.ProductSubCategory).Include(x => x.Product.ProductSubCategory.ProductCategory).ToListAsync<OrderDetail>();
            return OrderDetailList;
        }

        public async Task<OrderDetail> getSingleItem(int id)
        {
            OrderDetail OrderDetail = await KitchenStory_DbContext.OrderDetails.Include(x => x.Product).Include(x => x.Product.brand).Include(x => x.Order).Include(x => x.Product.ProductSubCategory).Include(x => x.Product.ProductSubCategory.ProductCategory).FirstAsync<OrderDetail>(p => p.OrderDetailId == id);
            return OrderDetail;
        }
        //public List<OrderDetail> GetOrderDetailCategories()
        //{

        //    List<OrderDetail> prodCatList = this.KitchenStory_DbContext.OrderDetailCategories.FromSqlRaw("exec  [dbo].[Get_OrderDetail] ").ToList();
        //    return prodCatList;
        //}
    }


}
