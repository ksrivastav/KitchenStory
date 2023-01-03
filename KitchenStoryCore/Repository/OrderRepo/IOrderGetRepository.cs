using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.OrderRepo
{
    public interface IOrderGetRepository
    {
        Task<IEnumerable<Order>> getAllItem();
        //T getSingleItem(string a, string b);

        Task<Order> getSingleItem(int id);
    }
}
