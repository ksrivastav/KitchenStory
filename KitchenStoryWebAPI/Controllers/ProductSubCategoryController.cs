using KitchenStoryCore.CoreServices.Services.ProductSubCatagoryServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.ProductSubCategoryContracts;
using KitchenStoryCore.CoreServices.Contracts.ProductContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.ProductSubCategory;
using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;
using Microsoft.AspNetCore.Authorization;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ProductSubCategoryController : Controller
    {
        private readonly IProductSubCategoryGetService ProductSubCategoryGetService;
        private readonly IProductSubCategoryInsertService ProductSubCategoryInsertService;
        private readonly IProductSubCategoryUpdateService ProductSubCategoryUpdateService;
        private readonly IProductSubCategoryDeleteService ProductSubCategoryDeleteService;

        private readonly IProductCategoryGetService productCategoryGetService;
        private IMapper mapper { get; }
        public ProductSubCategoryController(IProductSubCategoryDeleteService ProductSubCategoryDeleteService,IProductSubCategoryGetService ProductSubCategoryGetService,IProductSubCategoryInsertService ProductSubCategoryInsertService, IProductSubCategoryUpdateService ProductSubCategoryUpdateService,  IMapper mapper, IProductCategoryGetService ProductCategoryGetService) { 

            this.ProductSubCategoryGetService = ProductSubCategoryGetService;
            this.ProductSubCategoryInsertService = ProductSubCategoryInsertService;
            this.ProductSubCategoryUpdateService= ProductSubCategoryUpdateService;
            this.ProductSubCategoryDeleteService = ProductSubCategoryDeleteService;
            this.productCategoryGetService = ProductCategoryGetService;
            this.mapper = mapper;
        
        }

        [HttpGet]
        [Route("~/GetAllProductSubCategory")]
        public async Task<IActionResult> getAllProductSubCategory()
        {
            IEnumerable<ProductSubCategory> prodcatList = await ProductSubCategoryGetService.getAllItem();
            IEnumerable<ProductSubCategoryDTO> ProductSubCategoryDTOs = mapper.Map<IEnumerable<ProductSubCategoryDTO>>(prodcatList);

            return Ok(ProductSubCategoryDTOs);
        }

        [HttpGet]
        [Route("~/getProductSubCategoryById")]
        public async Task<IActionResult> getProductSubCategoryById( [FromQuery] int id)
        {
            ProductSubCategory ProductSubCategory = await this.ProductSubCategoryGetService.getSingleItem(id);
            return Ok(ProductSubCategory);
        }

        [HttpPost]
        [Route("~/insertProductSubCategory")]
        public async Task<IActionResult> insertProductSubCategory(ProductSubCategoryInsertRequest insertProductSubCategory)
        {
            ProductCategory productCategory =await  this.productCategoryGetService.getSingleItem(insertProductSubCategory.ProductCategoryId);
            ProductSubCategory ProductSubCategory = mapper.Map<ProductSubCategory>(insertProductSubCategory);
            ProductSubCategory.ProductCategory=productCategory;
            int id = await this.ProductSubCategoryInsertService.insertSingleItem(ProductSubCategory);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateProductSubCategory")]
        public async Task<IActionResult> updateProductSubCategory(ProductSubCategory ProductSubCategory)
        {
            ProductSubCategory updatedProductSubCategory = await this.ProductSubCategoryUpdateService.updateSingleItem(ProductSubCategory);
            return Ok(updatedProductSubCategory);
        }

        [HttpPost]
        [Route("~/deleteProductSubCategory")]
        public IActionResult deleteSingleItem(ProductSubCategory targetProductSubCategory)
        {
            try
            {
                 this.ProductSubCategoryDeleteService.deleteSingleItem(targetProductSubCategory);
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
