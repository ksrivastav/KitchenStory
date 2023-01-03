using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.Brand;
namespace KitchenStoryWebAPI.Profiles
{
    public class BrandInsertRequestProfile : Profile
    {
        public BrandInsertRequestProfile() {
            CreateMap<Brand, BrandInsertRequest>()
                .ReverseMap();
                 
            //.ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags));

        }
    }
}
