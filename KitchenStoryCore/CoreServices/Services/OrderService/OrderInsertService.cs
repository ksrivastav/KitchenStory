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
    public class OrderInsertService : IOrderInsertService
    {
        IOrderInsertRepository prodCatInsertRepository;
        private readonly ILogger<OrderInsertService> logger;
        DbContextOptions options;

        public OrderInsertService(DbContextOptions options, ILogger<OrderInsertService> logger, IOrderInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<Order> InsertAllItem()
        //{

        //    this.logger.LogInformation("Order categosry service InsertAllItem");
        //    List<Order> OrderList = this.prodCatInsertRepository.InsertAllItem();
        //    return OrderList;

        //}

        public async Task<int> insertSingleItem(Order Order)
        {
            int id = await prodCatInsertRepository.insertSingleItem(Order);
            return id;
        }


    }
}
