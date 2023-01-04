using KitchenStoryCore.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KitchenStoryCore.Repository.UserRepo;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using KitchenStoryCore.CoreServices.Contracts.UserContracts;


namespace KitchenStoryCore.CoreServices.Services.UserServices
{
    public class UserGetService : IUserGetService
    {
        IUserGetRepository prodCatGetRepository;
        ILogger<UserGetService> logger;
        DbContextOptions options;

        public UserGetService(DbContextOptions options, ILogger<UserGetService> logger, IUserGetRepository prodCatGetRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatGetRepository = prodCatGetRepository;

        }
        public  async Task<IEnumerable<User>> getAllItem()
        {

            logger.LogInformation("User categosry service getAllItem");
            IEnumerable<User> UserList = await prodCatGetRepository.getAllItem();
            return UserList;

        }
        public async Task<User> getSingleItem(string id)
        {
            User User = await prodCatGetRepository.getSingleItem(id);

            return User;
        }

    }
}
