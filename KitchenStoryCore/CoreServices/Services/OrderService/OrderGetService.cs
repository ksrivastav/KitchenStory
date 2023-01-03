using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.Repository.OrderRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.OrderContracts;


namespace KitchenStoryCore.CoreServices.Services.OrderServices
{
    public class OrderGetService : IOrderGetService
    {
        IOrderGetRepository prodCatGetRepository;
        ILogger<OrderGetService> logger;
        DbContextOptions options;

        public OrderGetService(DbContextOptions options, ILogger<OrderGetService> logger, IOrderGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<Order>> getAllItem()
        {

            logger.LogInformation("Order categosry service getAllItem");
            IEnumerable<Order> OrderList = await prodCatGetRepository.getAllItem();
            return OrderList;

        }
        public async Task<Order> getSingleItem(int id)
        {
            Order Order = await prodCatGetRepository.getSingleItem(id);

            return Order;
        }

    }
}
