using KitchenStoryCore.CoreServices.Services.ProductCategoryServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.ProductCategory;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryGetService productCategoryGetService;
        private readonly IProductCategoryInsertService productCategoryInsertService;
        private readonly IProductCategoryUpdateService productCategoryUpdateService;
        private readonly IProductCategoryDeleteService productCategoryDeleteService;
        private IMapper mapper { get; }
        public ProductCategoryController(IProductCategoryDeleteService productCategoryDeleteService,IProductCategoryGetService productCategoryGetService,IProductCategoryInsertService productCategoryInsertService, IProductCategoryUpdateService productCategoryUpdateService,  IMapper mapper) { 

            this.productCategoryGetService = productCategoryGetService;
            this.productCategoryInsertService = productCategoryInsertService;
            this.productCategoryUpdateService= productCategoryUpdateService;
            this.productCategoryDeleteService = productCategoryDeleteService;
            this.mapper = mapper;
        
        }

        [HttpGet]
        [Route("~/GetAllProductCategory")]
        public async Task<IActionResult> getAllProductCategory()
        {
            IEnumerable<ProductCategory> prodcatList = await productCategoryGetService.getAllItem();
            IEnumerable<ProductCategoryDTO> productCategoryDTOs = mapper.Map<IEnumerable<ProductCategoryDTO>>(prodcatList);

            return Ok(productCategoryDTOs);
        }

        [HttpGet]
        [Route("~/getProductCategoryById")]
        public async Task<IActionResult> getProductCategoryById( [FromQuery] int id)
        {
            ProductCategory productCategory = await this.productCategoryGetService.getSingleItem(id);
            return Ok(productCategory);
        }

        [HttpPost]
        [Route("~/insertProductCategory")]
        public async Task<IActionResult> insertProductCategory(ProductCategoryInsertRequest insertProductCategory)
        {
            ProductCategory productCategory = mapper.Map<ProductCategory>(insertProductCategory);
            int id = await this.productCategoryInsertService.insertSingleItem(productCategory);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateProductCategory")]
        public async Task<IActionResult> updateProductCategory(ProductCategory productCategory)
        {
            ProductCategory updatedProductCategory = await this.productCategoryUpdateService.updateSingleItem(productCategory);
            return Ok(updatedProductCategory);
        }

        [HttpPost]
        [Route("~/deleteProductCategory")]
        public IActionResult deleteSingleItem(ProductCategory targetProductCategory)
        {
            try
            {
                 this.productCategoryDeleteService.deleteSingleItem(targetProductCategory);
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
