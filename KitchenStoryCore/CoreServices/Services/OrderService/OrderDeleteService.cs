using KitchenStoryCore.Repository.OrderRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.OrderContracts;

namespace KitchenStoryCore.CoreServices.Services.OrderServices
{
    public class OrderDeleteService : IOrderDeleteService
    {
        IOrderDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<OrderDeleteService> logger;
        DbContextOptions options;

        public OrderDeleteService(DbContextOptions options, ILogger<OrderDeleteService> logger, IOrderDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public  void deleteSingleItem(Order targetOrder)
        {
            prodCatDeleteRepository.deleteSingleItem(targetOrder);
        }


    }
}
