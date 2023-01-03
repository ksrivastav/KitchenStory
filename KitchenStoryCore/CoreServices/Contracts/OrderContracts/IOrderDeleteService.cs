using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KitchenStoryCore.DomainModel;
using System.Threading.Tasks;

namespace KitchenStoryCore.CoreServices.Contracts.OrderContracts
{
    public interface IOrderDeleteService
    {
        void deleteSingleItem(Order targetOrder);


    }
}
