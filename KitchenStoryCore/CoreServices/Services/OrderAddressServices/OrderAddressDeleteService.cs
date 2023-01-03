using KitchenStoryCore.Repository.OrderAddressRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.OrderAddressContracts;

namespace KitchenStoryCore.CoreServices.Services.OrderAddressServices
{
    public class OrderAddressDeleteService : IOrderAddressDeleteService
    {
        IOrderAddressDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<OrderAddressDeleteService> logger;
        DbContextOptions options;

        public OrderAddressDeleteService(DbContextOptions options, ILogger<OrderAddressDeleteService> logger, IOrderAddressDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public  void deleteSingleItem(OrderAddress targetOrderAddress)
        {
            prodCatDeleteRepository.deleteSingleItem(targetOrderAddress);
        }


    }
}
