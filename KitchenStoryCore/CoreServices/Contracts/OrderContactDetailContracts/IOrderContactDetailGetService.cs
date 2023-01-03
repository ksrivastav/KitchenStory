using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.CoreServices.Contracts.OrderContactDetailContracts
{
    public interface IOrderContactDetailGetService
    {
        Task<IEnumerable<OrderContactDetail>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<OrderContactDetail> getSingleItem(int id);


    }
}
