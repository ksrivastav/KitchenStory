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
    public class OrderUpdateService :IOrderUpdateService
    {
        IOrderUpdateRepository prodCatUpdateRepository;
        IOrderGetRepository prodCatGetRepository;
        //ILogger<OrderUpdateService> logger;
        DbContextOptions options;

        public OrderUpdateService(DbContextOptions options, IOrderUpdateRepository prodCatUpdateRepository, IOrderGetRepository OrderGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = OrderGetRepository;

        }


        public async Task<Order> updateSingleItem(Order updatedOrder)
        {
           Order updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedOrder, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
