using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.Brand;
namespace KitchenStoryWebAPI.Profiles
{
    public class BrandDTOProfile: Profile
    {
        public BrandDTOProfile() {
            CreateMap<Brand, BrandDTO>()
                .ReverseMap();


                 
            //.ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags));

        }
    }
}
