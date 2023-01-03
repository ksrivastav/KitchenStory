using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.ProductCategory;

namespace KitchenStoryWebAPI.Profiles
{
    public class ProductCategoryInsertRequestProfile: Profile
    {
        public ProductCategoryInsertRequestProfile()
        {
            CreateMap<ProductCategoryDTO, ProductCategoryInsertRequest>()
             .ReverseMap()
             .ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags))
             .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name))
             .ForMember(dest => dest.Description, options => options.MapFrom(src => src.Description));
        }
    }
}
