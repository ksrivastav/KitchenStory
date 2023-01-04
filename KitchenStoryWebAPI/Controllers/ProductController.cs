using KitchenStoryCore.CoreServices.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.ProductContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.Product;
using KitchenStoryCore.CoreServices.Contracts.BrandContracts;
using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;
using KitchenStoryCore.CoreServices.Contracts.ProductSubCategoryContracts;
using KitchenStoryInfrastructure.Repositories.BrandRepo;
using Microsoft.AspNetCore.Authorization;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductGetService productGetService;
        private readonly IProductInsertService productInsertService;
        private readonly IProductUpdateService productUpdateService;
        private readonly IProductDeleteService productDeleteService;
        private readonly IBrandGetService brandGetService;
        private readonly IProductCategoryGetService productCategoryGetService;
        private readonly IProductSubCategoryGetService productsubCategoryGetService;
        private IMapper mapper { get; }
        public ProductController(IProductDeleteService productDeleteService,
                                IProductGetService productGetService,
                                IProductInsertService productInsertService,
                                IProductUpdateService productUpdateService,
                                IBrandGetService brandGetService,
                                IProductCategoryGetService productCategoryGetService,
                                IProductSubCategoryGetService productsubCategoryGetService,
                                IMapper mapper) { 

            this.productGetService = productGetService;
            this.productInsertService = productInsertService;
            this.productUpdateService= productUpdateService;
            this.productDeleteService = productDeleteService;
            this.brandGetService= brandGetService;
            this.productCategoryGetService = productCategoryGetService;
            this.productsubCategoryGetService= productsubCategoryGetService;
            this.mapper = mapper;
        
        }

        [HttpGet]
        [Route("~/GetAllProduct")]
        public async Task<IActionResult> getAllProduct()
        {
            IEnumerable<Product> prodcatList = await productGetService.getAllItem();
            IEnumerable<ProductDTO> productDTOs = mapper.Map<IEnumerable<ProductDTO>>(prodcatList);

            return Ok(productDTOs);
        }

        [HttpGet]
        [Route("~/getProductById")]
        public async Task<IActionResult> getProductById( [FromQuery] int id)
        {
            Product product = await this.productGetService.getSingleItem(id);
            return Ok(product);
        }

        [HttpPost]
        [Route("~/insertProduct")]
        public async Task<IActionResult> insertProduct(ProductInsertRequest insertProduct)
        {
            Product product = mapper.Map<Product>(insertProduct);
            product.brand = await this.brandGetService.getSingleItem(insertProduct.BrandId);
            product.ProductSubCategory = await this.productsubCategoryGetService.getSingleItem(insertProduct.ProductSubCategoryId);
            int id = await this.productInsertService.insertSingleItem(product);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateProduct")]
        public async Task<IActionResult> updateProduct(Product product)
        {
            Product updatedProduct = await this.productUpdateService.updateSingleItem(product);
            return Ok(updatedProduct);
        }

        [HttpPost]
        [Route("~/deleteProduct")]
        public IActionResult deleteSingleItem(Product targetProduct)
        {
            try
            {
                 this.productDeleteService.deleteSingleItem(targetProduct);
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
