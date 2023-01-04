using KitchenStoryCore.Repository.UserRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.UserContracts;

namespace KitchenStoryCore.CoreServices.Services.UserServices
{
    public class UserUpdateService :IUserUpdateService
    {
        IUserUpdateRepository prodCatUpdateRepository;
        IUserGetRepository prodCatGetRepository;
        //ILogger<UserUpdateService> logger;
        DbContextOptions options;

        public UserUpdateService(DbContextOptions options, IUserUpdateRepository prodCatUpdateRepository, IUserGetRepository UserGetRepository)
        {
            this.options = options;
           
            this.prodCatUpdateRepository = prodCatUpdateRepository;
            this.prodCatGetRepository = UserGetRepository;

        }


        public async Task<User> updateSingleItem(User updatedUser)
        {
           User updatedProdCat = await  prodCatUpdateRepository.updateSingleItem(updatedUser, this.prodCatGetRepository);
            return updatedProdCat;
        }


    }
}
