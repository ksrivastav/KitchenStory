using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.OrderAddressRepo
{
    public interface IOrderAddressInsertRepository
    {
         Task<int> insertSingleItem(OrderAddress OrderAddress);

    }
}
