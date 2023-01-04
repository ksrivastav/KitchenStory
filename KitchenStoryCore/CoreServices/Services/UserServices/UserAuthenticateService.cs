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
    public class UserAuthenticateService : IUserAuthenticateService
    {
        IUserAuthenticateRepository prodCatAuthenticateRepository;
        private readonly ILogger<UserAuthenticateService> logger;
        DbContextOptions options;

        public UserAuthenticateService(DbContextOptions options, ILogger<UserAuthenticateService> logger, IUserAuthenticateRepository prodCatAuthenticateRepository)
        {
            this.options = options;
            this.logger = logger;
            this.prodCatAuthenticateRepository = prodCatAuthenticateRepository;

        }


        public async Task<UserLogin> authenticate(string userEmail, string Password)
        {
            return await prodCatAuthenticateRepository.authenticate(userEmail, Password);
        }

        public  bool logout(string userEmail)
        {
            return  prodCatAuthenticateRepository.logout(userEmail);

        }


    }
}
