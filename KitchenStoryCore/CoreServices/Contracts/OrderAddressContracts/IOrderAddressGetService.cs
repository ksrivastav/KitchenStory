using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.CoreServices.Contracts.OrderAddressContracts
{
    public interface IOrderAddressGetService
    {
        Task<IEnumerable<OrderAddress>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<OrderAddress> getSingleItem(int id);


    }
}
