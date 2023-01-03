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
    public class OrderDetailUpdateService :IOrderDetailUpdateService
    {
        IOrderDetailUpdateRepository prodCatUpdateRepository;
        IOrderDetailGetRepository prodCatGetRepository;
        //ILogger<OrderDetailUpdateService> logger;
        DbContextOptions options;

        public OrderDetailUpdateService(DbContextOptions options, IOrderDetailUpdateRepository prodCatUpdateRepository, IOrderDetailGetRepository OrderDetailGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = OrderDetailGetRepository;

        }


        public async Task<OrderDetail> updateSingleItem(OrderDetail updatedOrderDetail)
        {
           OrderDetail updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedOrderDetail, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
