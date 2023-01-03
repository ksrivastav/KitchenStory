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
    public class OrderAddressUpdateService :IOrderAddressUpdateService
    {
        IOrderAddressUpdateRepository prodCatUpdateRepository;
        IOrderAddressGetRepository prodCatGetRepository;
        //ILogger<OrderAddressUpdateService> logger;
        DbContextOptions options;

        public OrderAddressUpdateService(DbContextOptions options, IOrderAddressUpdateRepository prodCatUpdateRepository, IOrderAddressGetRepository OrderAddressGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = OrderAddressGetRepository;

        }


        public async Task<OrderAddress> updateSingleItem(OrderAddress updatedOrderAddress)
        {
           OrderAddress updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedOrderAddress, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
