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
    public class OrderContactDetailUpdateService :IOrderContactDetailUpdateService
    {
        IOrderContactDetailUpdateRepository prodCatUpdateRepository;
        IOrderContactDetailGetRepository prodCatGetRepository;
        //ILogger<OrderContactDetailUpdateService> logger;
        DbContextOptions options;

        public OrderContactDetailUpdateService(DbContextOptions options, IOrderContactDetailUpdateRepository prodCatUpdateRepository, IOrderContactDetailGetRepository OrderContactDetailGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = OrderContactDetailGetRepository;

        }


        public async Task<OrderContactDetail> updateSingleItem(OrderContactDetail updatedOrderContactDetail)
        {
           OrderContactDetail updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedOrderContactDetail, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
