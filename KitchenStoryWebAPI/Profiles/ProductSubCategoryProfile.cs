using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.ProductSubCategory;

namespace KitchenStoryWebAPI.Profiles
{
    public class ProductSubCategoryProfile: Profile
    {
        public ProductSubCategoryProfile() {
            CreateMap<ProductSubCategory, ProductSubCategoryDTO>()
                .ReverseMap();
                 
            //.ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags));

        }
    }
}
