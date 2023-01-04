using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KitchenStoryCore.DomainModel;
using System.Threading.Tasks;

namespace KitchenStoryCore.CoreServices.Contracts.UserContracts
{
    public interface IUserTokenHandlerService
    {
        Task<string> createTokenAsync(UserLogin targetUser);


    }
}
