using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KitchenStoryCore.DomainModel;
using System.Threading.Tasks;

namespace KitchenStoryCore.CoreServices.Contracts.UserContracts
{
    public interface IUserAuthenticateService
    {
        Task<UserLogin> authenticate(string userEmail, string Password);
        bool logout(string userEmail);


    }
}
