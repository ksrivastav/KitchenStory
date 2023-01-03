using KitchenStoryCore.Repository.OrderContactDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.OrderContactDetailContracts;

namespace KitchenStoryCore.CoreServices.Services.OrderContactDetailServices
{
    public class OrderContactDetailDeleteService : IOrderContactDetailDeleteService
    {
        IOrderContactDetailDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<OrderContactDetailDeleteService> logger;
        DbContextOptions options;

        public OrderContactDetailDeleteService(DbContextOptions options, ILogger<OrderContactDetailDeleteService> logger, IOrderContactDetailDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public  void deleteSingleItem(OrderContactDetail targetOrderContactDetail)
        {
            prodCatDeleteRepository.deleteSingleItem(targetOrderContactDetail);
        }


    }
}
