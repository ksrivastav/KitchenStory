using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.ProductSubCategory;

namespace KitchenStoryWebAPI.Profiles
{
    public class ProductSubCategoryInsertRequestProfile: Profile
    {
        public ProductSubCategoryInsertRequestProfile()
        {
            CreateMap<ProductSubCategory, ProductSubCategoryInsertRequest>()
             .ReverseMap()
             .ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags))
             .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name))
             .ForMember(dest => dest.Description, options => options.MapFrom(src => src.Description));          

        }
    }
}
