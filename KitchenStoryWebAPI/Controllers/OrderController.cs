using KitchenStoryCore.CoreServices.Services.OrderServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.OrderContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.Order;
using Microsoft.AspNetCore.Authorization;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderGetService OrderGetService;
        private readonly IOrderInsertService OrderInsertService;
        private readonly IOrderUpdateService OrderUpdateService;
        private readonly IOrderDeleteService OrderDeleteService;
        private IMapper mapper { get; }
        public OrderController(IOrderDeleteService OrderDeleteService,IOrderGetService OrderGetService,IOrderInsertService OrderInsertService, IOrderUpdateService OrderUpdateService,  IMapper mapper) { 

            this.OrderGetService = OrderGetService;
            this.OrderInsertService = OrderInsertService;
            this.OrderUpdateService= OrderUpdateService;
            this.OrderDeleteService = OrderDeleteService;
            this.mapper = mapper;
        
        }

        [HttpGet]
        [Route("~/GetAllOrder")]
        public async Task<IActionResult> getAllOrder()
        {
            IEnumerable<Order> prodcatList = await OrderGetService.getAllItem();
            IEnumerable<OrderDTO> OrderDTOs = mapper.Map<IEnumerable<OrderDTO>>(prodcatList);

            return Ok(OrderDTOs);
        }

        [HttpGet]
        [Route("~/getOrderById")]
        public async Task<IActionResult> getOrderById( [FromQuery] int id)
        {
            Order Order = await this.OrderGetService.getSingleItem(id);
            return Ok(Order);
        }

        [HttpPost]
        [Route("~/insertOrder")]
        public async Task<IActionResult> insertOrder(OrderInsertRequest insertOrder)
        {
            Order Order = mapper.Map<Order>(insertOrder);
            int id = await this.OrderInsertService.insertSingleItem(Order);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateOrder")]
        public async Task<IActionResult> updateOrder(Order Order)
        {
            Order updatedOrder = await this.OrderUpdateService.updateSingleItem(Order);
            return Ok(updatedOrder);
        }

        [HttpPost]
        [Route("~/deleteOrder")]
        public IActionResult deleteSingleItem(Order targetOrder)
        {
            try
            {
                 this.OrderDeleteService.deleteSingleItem(targetOrder);
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
