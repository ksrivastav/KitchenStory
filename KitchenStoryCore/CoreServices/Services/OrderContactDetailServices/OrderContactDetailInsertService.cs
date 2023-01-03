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
    public class OrderContactDetailInsertService : IOrderContactDetailInsertService
    {
        IOrderContactDetailInsertRepository prodCatInsertRepository;
        private readonly ILogger<OrderContactDetailInsertService> logger;
        DbContextOptions options;

        public OrderContactDetailInsertService(DbContextOptions options, ILogger<OrderContactDetailInsertService> logger, IOrderContactDetailInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<OrderContactDetail> InsertAllItem()
        //{

        //    this.logger.LogInformation("OrderContactDetail categosry service InsertAllItem");
        //    List<OrderContactDetail> OrderContactDetailList = this.prodCatInsertRepository.InsertAllItem();
        //    return OrderContactDetailList;

        //}

        public async Task<int> insertSingleItem(OrderContactDetail OrderContactDetail)
        {
            int id = await prodCatInsertRepository.insertSingleItem(OrderContactDetail);
            return id;
        }


    }
}
