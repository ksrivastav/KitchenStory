using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.OrderContactDetailRepo
{
    public interface IOrderContactDetailUpdateRepository
    {
        Task<OrderContactDetail> updateSingleItem(OrderContactDetail OrderContactDetail, IOrderContactDetailGetRepository OrderContactDetailGetRepository);


    }
}
