using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.OrderAddress;

namespace KitchenStoryWebAPI.Profiles
{
    public class OrderAddressDetailDTOProfile : Profile
    {
        public OrderAddressDetailDTOProfile()
        {
            CreateMap<OrderAddress, OrderAddressDTO>()
                .ReverseMap();

            CreateMap<OrderAddress, OrderAddressInsertRequestDTO>()
                               .ReverseMap();
        }
    }
}
