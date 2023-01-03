using AutoMapper;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.OrderContactDetail;

namespace KitchenStoryWebAPI.Profiles
{
    public class OrderContactDetailDTOProfile : Profile
    {
        public OrderContactDetailDTOProfile()
        {
            CreateMap<OrderContactDetail, OrderContactDetailDTO>()
                .ReverseMap();

            CreateMap<OrderContactDetail, OrderContactDetailInsertRequest>()
                               .ReverseMap();
        }
    }
}
