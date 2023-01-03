using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.Repository.OrderDetailRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.OrderDetailContracts;


namespace KitchenStoryCore.CoreServices.Services.OrderDetailServices
{
    public class OrderDetailGetService : IOrderDetailGetService
    {
        IOrderDetailGetRepository prodCatGetRepository;
        ILogger<OrderDetailGetService> logger;
        DbContextOptions options;

        public OrderDetailGetService(DbContextOptions options, ILogger<OrderDetailGetService> logger, IOrderDetailGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<OrderDetail>> getAllItem()
        {

            logger.LogInformation("OrderDetail categosry service getAllItem");
            IEnumerable<OrderDetail> OrderDetailList = await prodCatGetRepository.getAllItem();
            return OrderDetailList;

        }
        public async Task<OrderDetail> getSingleItem(int id)
        {
            OrderDetail OrderDetail = await prodCatGetRepository.getSingleItem(id);

            return OrderDetail;
        }

    }
}
