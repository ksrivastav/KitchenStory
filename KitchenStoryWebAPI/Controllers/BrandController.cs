using KitchenStoryCore.CoreServices.Services.BrandServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.BrandContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.Brand;
namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : Controller
    {
        private readonly IBrandGetService BrandGetService;
        private readonly IBrandInsertService BrandInsertService;
        private readonly IBrandUpdateService BrandUpdateService;
        private readonly IBrandDeleteService BrandDeleteService;
        private IMapper mapper { get; }
        public BrandController(IBrandDeleteService BrandDeleteService, IBrandGetService BrandGetService, IBrandInsertService BrandInsertService, IBrandUpdateService BrandUpdateService, IMapper mapper)
        {

            this.BrandGetService = BrandGetService;
            this.BrandInsertService = BrandInsertService;
            this.BrandUpdateService = BrandUpdateService;
            this.BrandDeleteService = BrandDeleteService;
            this.mapper = mapper;

        }

        [HttpGet]
        [Route("~/GetAllBrand")]
        public async Task<IActionResult> getAllBrand()
        {
            IEnumerable<Brand> prodcatList = await BrandGetService.getAllItem();
            IEnumerable<BrandDTO> BrandDTOs = mapper.Map<IEnumerable<BrandDTO>>(prodcatList);

            return Ok(BrandDTOs);
        }

        [HttpGet]
        [Route("~/getBrandById")]
        public async Task<IActionResult> getBrandById([FromQuery] int id)
        {
            Brand Brand = await this.BrandGetService.getSingleItem(id);
            return Ok(Brand);
        }

        [HttpPost]
        [Route("~/insertBrand")]
        public async Task<IActionResult> insertBrand(BrandInsertRequest insertBrand)
        {
            Brand Brand = mapper.Map<Brand>(insertBrand);

            int id = await this.BrandInsertService.insertSingleItem(Brand);
            return Ok(id);
        }

        [HttpPost]
        [Route("~/updateBrand")]
        public async Task<IActionResult> updateBrand(Brand Brand)
        {
            Brand updatedBrand = await this.BrandUpdateService.updateSingleItem(Brand);
            return Ok(updatedBrand);
        }

        [HttpPost]
        [Route("~/deleteBrand")]
        public IActionResult deleteSingleItem(Brand targetBrand)
        {
            try
            {
                this.BrandDeleteService.deleteSingleItem(targetBrand);
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
