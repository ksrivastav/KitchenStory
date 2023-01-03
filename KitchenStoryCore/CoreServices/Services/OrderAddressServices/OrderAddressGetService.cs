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
    public class OrderAddressGetService : IOrderAddressGetService
    {
        IOrderAddressGetRepository prodCatGetRepository;
        ILogger<OrderAddressGetService> logger;
        DbContextOptions options;

        public OrderAddressGetService(DbContextOptions options, ILogger<OrderAddressGetService> logger, IOrderAddressGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<OrderAddress>> getAllItem()
        {

            logger.LogInformation("OrderAddress categosry service getAllItem");
            IEnumerable<OrderAddress> OrderAddressList = await prodCatGetRepository.getAllItem();
            return OrderAddressList;

        }
        public async Task<OrderAddress> getSingleItem(int id)
        {
            OrderAddress OrderAddress = await prodCatGetRepository.getSingleItem(id);

            return OrderAddress;
        }

    }
}
