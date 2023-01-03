using KitchenStoryCore.CoreServices.Services.OrderAddressServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.OrderAddressContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.OrderAddress;
using KitchenStoryCore.CoreServices.Contracts.OrderContracts;
//using KitchenStoryCore.CoreServices.Contracts.OrderAddressContracts;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderAddressController : Controller
    {
        private readonly IOrderAddressGetService OrderAddressGetService;
        private readonly IOrderAddressInsertService OrderAddressInsertService;
        private readonly IOrderAddressUpdateService OrderAddressUpdateService;
        private readonly IOrderAddressDeleteService OrderAddressDeleteService;
        private readonly IOrderGetService OrderGetService;
       
        private IMapper mapper { get; }
        public OrderAddressController(IOrderAddressDeleteService OrderAddressDeleteService,IOrderAddressGetService OrderAddressGetService, IOrderAddressInsertService OrderAddressInsertService, IOrderAddressUpdateService OrderAddressUpdateService, IOrderGetService OrderGetService,  IMapper mapper)
        {

            this.OrderAddressGetService = OrderAddressGetService;
            this.OrderAddressInsertService = OrderAddressInsertService;
            this.OrderAddressUpdateService = OrderAddressUpdateService;
            this.OrderAddressDeleteService = OrderAddressDeleteService;
            this.OrderGetService = OrderGetService;
            
            this.mapper = mapper;

        }

        [HttpGet]
        [Route("~/GetAllOrderAddress")]
        public async Task<IActionResult> getAllOrderAddress()
        {
            IEnumerable<OrderAddress> prodcatList = await OrderAddressGetService.getAllItem();
            IEnumerable<OrderAddressDTO> OrderAddressDTOs = mapper.Map<IEnumerable<OrderAddressDTO>>(prodcatList);

            return Ok(OrderAddressDTOs);
        }

        [HttpGet]
        [Route("~/getOrderAddressById")]
        public async Task<IActionResult> getOrderAddressById([FromQuery] int id)
        {
            OrderAddress OrderAddress = await this.OrderAddressGetService.getSingleItem(id);
            return Ok(OrderAddress);
        }

        [HttpPost]
        [Route("~/insertOrderAddress")]
        public async Task<IActionResult> insertOrderAddress(OrderAddressInsertRequestDTO insertOrderAddress)
        {
            OrderAddress OrderAddress = mapper.Map<OrderAddress>(insertOrderAddress);

            OrderAddress.Order =await this.OrderGetService.getSingleItem(insertOrderAddress.OrderId);
            //OrderAddress.DeliveryAddress = await this.OrderAddressGetService.getSingleItem(insertOrderAddress.DeliveryAddressId);

            int id = await this.OrderAddressInsertService.insertSingleItem(OrderAddress);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateOrderAddress")]
        public async Task<IActionResult> updateOrderAddress(OrderAddress OrderAddress)
        {
            OrderAddress updatedOrderAddress = await this.OrderAddressUpdateService.updateSingleItem(OrderAddress);
            return Ok(updatedOrderAddress);
        }

        [HttpPost]
        [Route("~/deleteOrderAddress")]
        public IActionResult deleteSingleItem(OrderAddress targetOrderAddress)
        {
            try
            {
                this.OrderAddressDeleteService.deleteSingleItem(targetOrderAddress);
                return Ok(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(0);
            }
        }

    }
}
