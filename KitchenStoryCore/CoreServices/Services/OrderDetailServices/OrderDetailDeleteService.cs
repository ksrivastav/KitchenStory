using KitchenStoryCore.Repository.OrderDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.OrderDetailContracts;

namespace KitchenStoryCore.CoreServices.Services.OrderDetailServices
{
    public class OrderDetailDeleteService : IOrderDetailDeleteService
    {
        IOrderDetailDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<OrderDetailDeleteService> logger;
        DbContextOptions options;

        public OrderDetailDeleteService(DbContextOptions options, ILogger<OrderDetailDeleteService> logger, IOrderDetailDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public  void deleteSingleItem(OrderDetail targetOrderDetail)
        {
            prodCatDeleteRepository.deleteSingleItem(targetOrderDetail);
        }


    }
}
