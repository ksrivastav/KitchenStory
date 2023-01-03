using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.Product;

namespace KitchenStoryWebAPI.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile() {
            CreateMap<Product, ProductInsertRequest>()
                .ReverseMap();
            CreateMap<Product, ProductDTO>()
            .ReverseMap();

            //.ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags));

        }
    }
}
