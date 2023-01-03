using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.OrderDetail;

namespace KitchenStoryWebAPI.Profiles
{
    public class OrderDetailDTOProfile : Profile
    {
        public OrderDetailDTOProfile()
        {
            CreateMap<OrderDetail, OrderDetailDTO>()
                .ReverseMap();

            CreateMap<OrderDetail, OrderDetailInsertRequest>()
                               .ReverseMap();
        }
    }
}
