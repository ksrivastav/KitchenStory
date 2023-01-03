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
    public class OrderDetailInsertService : IOrderDetailInsertService
    {
        IOrderDetailInsertRepository prodCatInsertRepository;
        private readonly ILogger<OrderDetailInsertService> logger;
        DbContextOptions options;

        public OrderDetailInsertService(DbContextOptions options, ILogger<OrderDetailInsertService> logger, IOrderDetailInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<OrderDetail> InsertAllItem()
        //{

        //    this.logger.LogInformation("OrderDetail categosry service InsertAllItem");
        //    List<OrderDetail> OrderDetailList = this.prodCatInsertRepository.InsertAllItem();
        //    return OrderDetailList;

        //}

        public async Task<int> insertSingleItem(OrderDetail OrderDetail)
        {
            int id = await prodCatInsertRepository.insertSingleItem(OrderDetail);
            return id;
        }


    }
}
