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
    public class UserTokenHandlerService : IUserTokenHandlerService
    {
        IUserTokenHandlerRepository prodCatAuthenticateRepository;
        private readonly ILogger<UserTokenHandlerService> logger;
        DbContextOptions options;

        public UserTokenHandlerService(DbContextOptions options, ILogger<UserTokenHandlerService> logger, IUserTokenHandlerRepository prodCatAuthenticateRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatAuthenticateRepository = prodCatAuthenticateRepository;

        }


        public async Task<string> createTokenAsync(UserLogin targetUser)
        {
            return await prodCatAuthenticateRepository.createTokenAsync(targetUser);
        }


    }
}
