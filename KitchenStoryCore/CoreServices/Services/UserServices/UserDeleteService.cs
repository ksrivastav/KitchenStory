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
    public class UserDeleteService : IUserDeleteService
    {
        IUserDeleteRepository prodCatDeleteRepository;
        private readonly ILogger<UserDeleteService> logger;
        DbContextOptions options;

        public UserDeleteService(DbContextOptions options, ILogger<UserDeleteService> logger, IUserDeleteRepository prodCatDeleteRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatDeleteRepository = prodCatDeleteRepository;

        }


        public  void deleteSingleItem(User targetUser)
        {
            prodCatDeleteRepository.deleteSingleItem(targetUser);
        }


    }
}
