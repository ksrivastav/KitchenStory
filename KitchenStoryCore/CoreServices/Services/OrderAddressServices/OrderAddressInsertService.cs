using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.Repository.OrderAddressRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.OrderAddressContracts;

namespace KitchenStoryCore.CoreServices.Services.OrderAddressServices
{
    public class OrderAddressInsertService : IOrderAddressInsertService
    {
        IOrderAddressInsertRepository prodCatInsertRepository;
        private readonly ILogger<OrderAddressInsertService> logger;
        DbContextOptions options;

        public OrderAddressInsertService(DbContextOptions options, ILogger<OrderAddressInsertService> logger, IOrderAddressInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<OrderAddress> InsertAllItem()
        //{

        //    this.logger.LogInformation("OrderAddress categosry service InsertAllItem");
        //    List<OrderAddress> OrderAddressList = this.prodCatInsertRepository.InsertAllItem();
        //    return OrderAddressList;

        //}

        public async Task<int> insertSingleItem(OrderAddress OrderAddress)
        {
            int id = await prodCatInsertRepository.insertSingleItem(OrderAddress);
            return id;
        }


    }
}
