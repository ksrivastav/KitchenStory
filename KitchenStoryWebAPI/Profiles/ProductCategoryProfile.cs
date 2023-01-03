using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.ProductCategory;

namespace KitchenStoryWebAPI.Profiles
{
    public class ProductCategoryProfile: Profile
    {
        public ProductCategoryProfile() {
            CreateMap<ProductCategory, ProductCategoryDTO>()
                .ReverseMap();
            CreateMap<ProductCategory, ProductCategoryInsertRequest>()
             .ReverseMap();
                //.ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags));

        }
    }
}
