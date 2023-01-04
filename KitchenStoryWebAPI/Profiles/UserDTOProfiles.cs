using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.Users;
namespace KitchenStoryWebAPI.Profiles
{
    public class UserDTOProfile: Profile
    {
        public UserDTOProfile() {
            CreateMap<User, UserDTO>()
                .ReverseMap();
            CreateMap<User, UserInsertRequest>()
                .ForMember(dest => dest.Username, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.AddressLine2, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.AddressLine1, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Firstname, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.City, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Password, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.ConfirmPassword, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Country, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, option => option.MapFrom(src => src.UserName))
                .ForMember(dest => dest.DateOfBirth, option => option.MapFrom(src => src.UserName))
                //.ForMember(dest => dest., option => option.MapFrom(src => src.))
                .ReverseMap();
            CreateMap<UserLogin, UserLoginDTO>().ReverseMap();


                 
            //.ForMember(dest => dest.tags, options => options.MapFrom(src => src.tags));

        }
    }
}
