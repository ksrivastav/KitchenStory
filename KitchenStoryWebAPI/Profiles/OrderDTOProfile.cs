using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.Order;

namespace KitchenStoryWebAPI.Profiles
{
    public class OrderDTOProfile : Profile
    {
        public OrderDTOProfile()
        {
            CreateMap<Order, OrderDTO>()
                .ReverseMap();

            CreateMap<Order, OrderInsertRequest>()
                               .ReverseMap();
        }
    }
}
