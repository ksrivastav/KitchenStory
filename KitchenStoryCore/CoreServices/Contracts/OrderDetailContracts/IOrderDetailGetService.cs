using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.CoreServices.Contracts.OrderDetailContracts
{
    public interface IOrderDetailGetService
    {
        Task<IEnumerable<OrderDetail>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<OrderDetail> getSingleItem(int id);


    }
}
