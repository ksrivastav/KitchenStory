using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO;
namespace KitchenStoryWebAPI.Profiles
{
    public class ProductCategoryProfile: Profile
    {
        public ProductCategoryProfile() {
            CreateMap<ProductCategory, ProductCategoryDTO>()
                .ReverseMap();
                //.ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags));
        
        }
    }
}
