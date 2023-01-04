using KitchenStoryCore.CoreServices.Services.OrderDetailServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.OrderDetailContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.OrderDetail;
using KitchenStoryCore.CoreServices.Contracts.OrderContracts;
using KitchenStoryCore.CoreServices.Contracts.ProductContracts;
using Microsoft.AspNetCore.Authorization;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailGetService OrderDetailGetService;
        private readonly IOrderDetailInsertService OrderDetailInsertService;
        private readonly IOrderDetailUpdateService OrderDetailUpdateService;
        private readonly IOrderDetailDeleteService OrderDetailDeleteService;
        private readonly IOrderGetService OrderGetService;
        private readonly IProductGetService ProductGetService;
        private IMapper mapper { get; }
        public OrderDetailController(IOrderDetailDeleteService OrderDetailDeleteService,
                                     IOrderDetailGetService OrderDetailGetService,
                                     IOrderDetailInsertService OrderDetailInsertService,
                                     IOrderDetailUpdateService OrderDetailUpdateService,
                                     IOrderGetService OrderGetService,
                                     IProductGetService ProductGetService,
                                     IMapper mapper) { 

            this.OrderDetailGetService = OrderDetailGetService;
            this.OrderDetailInsertService = OrderDetailInsertService;
            this.OrderDetailUpdateService= OrderDetailUpdateService;
            this.OrderDetailDeleteService = OrderDetailDeleteService;
            this.OrderGetService = OrderGetService;
            this.ProductGetService = ProductGetService;
            this.mapper = mapper;
        
        }

        [HttpGet]
        [Route("~/GetAllOrderDetail")]
        public async Task<IActionResult> getAllOrderDetail()
        {
            IEnumerable<OrderDetail> prodcatList = await OrderDetailGetService.getAllItem();
            IEnumerable<OrderDetailDTO> OrderDetailDTOs = mapper.Map<IEnumerable<OrderDetailDTO>>(prodcatList);

            return Ok(OrderDetailDTOs);
        }

        [HttpGet]
        [Route("~/getOrderDetailById")]
        public async Task<IActionResult> getOrderDetailById( [FromQuery] int id)
        {
            OrderDetail OrderDetail = await this.OrderDetailGetService.getSingleItem(id);
            return Ok(OrderDetail);
        }

        [HttpPost]
        [Route("~/insertOrderDetail")]
        public async Task<IActionResult> insertOrderDetail(OrderDetailInsertRequest insertOrderDetail)
        {
            OrderDetail OrderDetail = mapper.Map<OrderDetail>(insertOrderDetail);
            OrderDetail.Order = await this.OrderGetService.getSingleItem(insertOrderDetail.OrderId);
            OrderDetail.Product = await this.ProductGetService.getSingleItem(insertOrderDetail.ProductId);
            int id = await this.OrderDetailInsertService.insertSingleItem(OrderDetail);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateOrderDetail")]
        public async Task<IActionResult> updateOrderDetail(OrderDetail OrderDetail)
        {
            OrderDetail updatedOrderDetail = await this.OrderDetailUpdateService.updateSingleItem(OrderDetail);
            return Ok(updatedOrderDetail);
        }

        [HttpPost]
        [Route("~/deleteOrderDetail")]
        public IActionResult deleteSingleItem(OrderDetail targetOrderDetail)
        {
            try
            {
                 this.OrderDetailDeleteService.deleteSingleItem(targetOrderDetail);
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
