using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.UserRepo
{
    public interface IUserGetRepository
    {
        Task<IEnumerable<User>> getAllItem();
        //T getSingleItem(string a, string b);
      
        Task<User> getSingleItem(string id );
    }
}
