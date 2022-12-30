using KitchenStoryCore.CoreServices.Services.ProductCategoryServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryGetService productCategoryGetService;
        private IMapper mapper { get; }
        public ProductCategoryController(IProductCategoryGetService productCategoryGetService, IMapper mapper) { 

            this.productCategoryGetService = productCategoryGetService;
            this.mapper = mapper;
        
        }

        [HttpGet(Name = "GetAllProductCategory")]
        public async Task<IActionResult> getAllProductCategory()
        {
            IEnumerable<ProductCategory> prodcatList = await productCategoryGetService.getAllItem();
            IEnumerable<ProductCategoryDTO> productCategoryDTOs = mapper.Map<IEnumerable<ProductCategoryDTO>>(prodcatList);

            return Ok(productCategoryDTOs);
        }
    }
}
