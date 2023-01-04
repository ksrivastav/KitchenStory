using KitchenStoryCore.CoreServices.Services.OrderContactDetailServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.OrderContactDetailContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.OrderContactDetail;
using KitchenStoryCore.CoreServices.Contracts.OrderContracts;
using KitchenStoryCore.CoreServices.Contracts.OrderAddressContracts;
using Microsoft.AspNetCore.Authorization;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class OrderContactDetailController : Controller
    {
        private readonly IOrderContactDetailGetService OrderContactDetailGetService;
        private readonly IOrderContactDetailInsertService OrderContactDetailInsertService;
        private readonly IOrderContactDetailUpdateService OrderContactDetailUpdateService;
        private readonly IOrderContactDetailDeleteService OrderContactDetailDeleteService;
        private readonly IOrderGetService OrderGetService;
       
        private IMapper mapper { get; }
        public OrderContactDetailController(IOrderContactDetailDeleteService OrderContactDetailDeleteService,IOrderContactDetailGetService OrderContactDetailGetService, IOrderContactDetailInsertService OrderContactDetailInsertService, IOrderContactDetailUpdateService OrderContactDetailUpdateService, IOrderGetService OrderGetService,  IMapper mapper)
        {

            this.OrderContactDetailGetService = OrderContactDetailGetService;
            this.OrderContactDetailInsertService = OrderContactDetailInsertService;
            this.OrderContactDetailUpdateService = OrderContactDetailUpdateService;
            this.OrderContactDetailDeleteService = OrderContactDetailDeleteService;
            this.OrderGetService = OrderGetService;
            
            this.mapper = mapper;

        }

        [HttpGet]
        [Route("~/GetAllOrderContactDetail")]
        public async Task<IActionResult> getAllOrderContactDetail()
        {
            IEnumerable<OrderContactDetail> prodcatList = await OrderContactDetailGetService.getAllItem();
            IEnumerable<OrderContactDetailDTO> OrderContactDetailDTOs = mapper.Map<IEnumerable<OrderContactDetailDTO>>(prodcatList);

            return Ok(OrderContactDetailDTOs);
        }

        [HttpGet]
        [Route("~/getOrderContactDetailById")]
        public async Task<IActionResult> getOrderContactDetailById([FromQuery] int id)
        {
            OrderContactDetail OrderContactDetail = await this.OrderContactDetailGetService.getSingleItem(id);
            return Ok(OrderContactDetail);
        }

        [HttpPost]
        [Route("~/insertOrderContactDetail")]
        public async Task<IActionResult> insertOrderContactDetail(OrderContactDetailInsertRequest insertOrderContactDetail)
        {
            OrderContactDetail OrderContactDetail = mapper.Map<OrderContactDetail>(insertOrderContactDetail);

            OrderContactDetail.Order =await this.OrderGetService.getSingleItem(insertOrderContactDetail.OrderId);
            //OrderContactDetail.DeliveryAddress = await this.OrderAddressGetService.getSingleItem(insertOrderContactDetail.DeliveryAddressId);

            int id = await this.OrderContactDetailInsertService.insertSingleItem(OrderContactDetail);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateOrderContactDetail")]
        public async Task<IActionResult> updateOrderContactDetail(OrderContactDetail OrderContactDetail)
        {
            OrderContactDetail updatedOrderContactDetail = await this.OrderContactDetailUpdateService.updateSingleItem(OrderContactDetail);
            return Ok(updatedOrderContactDetail);
        }

        [HttpPost]
        [Route("~/deleteOrderContactDetail")]
        public IActionResult deleteSingleItem(OrderContactDetail targetOrderContactDetail)
        {
            try
            {
                this.OrderContactDetailDeleteService.deleteSingleItem(targetOrderContactDetail);
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
