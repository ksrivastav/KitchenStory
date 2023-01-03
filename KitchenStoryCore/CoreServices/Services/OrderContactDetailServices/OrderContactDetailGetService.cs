using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.Repository.OrderContactDetailRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.OrderContactDetailContracts;


namespace KitchenStoryCore.CoreServices.Services.OrderContactDetailServices
{
    public class OrderContactDetailGetService : IOrderContactDetailGetService
    {
        IOrderContactDetailGetRepository prodCatGetRepository;
        ILogger<OrderContactDetailGetService> logger;
        DbContextOptions options;

        public OrderContactDetailGetService(DbContextOptions options, ILogger<OrderContactDetailGetService> logger, IOrderContactDetailGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<OrderContactDetail>> getAllItem()
        {

            logger.LogInformation("OrderContactDetail categosry service getAllItem");
            IEnumerable<OrderContactDetail> OrderContactDetailList = await prodCatGetRepository.getAllItem();
            return OrderContactDetailList;

        }
        public async Task<OrderContactDetail> getSingleItem(int id)
        {
            OrderContactDetail OrderContactDetail = await prodCatGetRepository.getSingleItem(id);

            return OrderContactDetail;
        }

    }
}
