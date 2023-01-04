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
    public class UserInsertService : IUserInsertService
    {
        IUserInsertRepository prodCatInsertRepository;
        private readonly ILogger<UserInsertService> logger;
        DbContextOptions options;

        public UserInsertService(DbContextOptions options, ILogger<UserInsertService> logger, IUserInsertRepository prodCatInsertRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatInsertRepository = prodCatInsertRepository;

        }
        //public List<User> InsertAllItem()
        //{

        //    this.logger.LogInformation("User categosry service InsertAllItem");
        //    List<User> UserList = this.prodCatInsertRepository.InsertAllItem();
        //    return UserList;

        //}

        public async Task<bool> insertSingleItem(User User, string userRole)
        {
            return await prodCatInsertRepository.insertSingleItem( User, userRole);
            //return id;
        }


    }
}
