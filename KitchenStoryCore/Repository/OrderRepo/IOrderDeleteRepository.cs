using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.OrderRepo
{
    public interface IOrderDeleteRepository
    {
        void deleteSingleItem(Order targetOrder);


    }
}
