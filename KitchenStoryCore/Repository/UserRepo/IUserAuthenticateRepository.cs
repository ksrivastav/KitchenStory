using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenStoryCore.DomainModel;

namespace KitchenStoryCore.Repository.UserRepo
{
    public interface IUserAuthenticateRepository
    {
        Task<UserLogin> authenticate(string userEmail, string Password);
        bool logout(string userEmail);


    }
}
