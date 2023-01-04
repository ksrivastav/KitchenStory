using KitchenStoryCore.CoreServices.Services.UserServices;
using Microsoft.AspNetCore.Mvc;
using KitchenStoryCore.CoreServices.Contracts.UserContracts;
using KitchenStoryCore.DomainModel;
using AutoMapper;
using KitchenStoryWebAPI.DTO.Users;
using Microsoft.AspNetCore.Authorization;
using System.Web.Helpers;
using Microsoft.Extensions.Primitives;

namespace KitchenStoryWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class AccountController : Controller
    {
        private readonly IUserGetService UserGetService;
        private readonly IUserInsertService UserInsertService;
        private readonly IUserUpdateService UserUpdateService;
        private readonly IUserDeleteService UserDeleteService;
        private readonly IUserAuthenticateService UserAuthenticateService;
        private readonly IUserTokenHandlerService userTokenHandlerService; 
        private IMapper mapper { get; }
        public AccountController(IUserDeleteService UserDeleteService, IUserGetService UserGetService, IUserInsertService UserInsertService, IUserUpdateService UserUpdateService, IUserAuthenticateService UserAuthenticateService , IUserTokenHandlerService userTokenHandlerService ,IMapper mapper)
        {

            this.UserGetService = UserGetService;
            this.UserInsertService = UserInsertService;
            this.UserUpdateService = UserUpdateService;
            this.UserDeleteService = UserDeleteService;
            this.UserAuthenticateService = UserAuthenticateService;
            this.userTokenHandlerService=userTokenHandlerService;
            this.mapper = mapper;

        }

        
        [HttpGet]
        [Route("~/GetAllUser")]
        public async Task<IActionResult> getAllUser()
        {
            IEnumerable<User> prodcatList = await UserGetService.getAllItem();
            IEnumerable<UserDTO> UserDTOs = mapper.Map<IEnumerable<UserDTO>>(prodcatList);

            return Ok(UserDTOs);
        }
        

        [HttpGet]
        [Route("~/getUserByEmailId")]
        public async Task<IActionResult> getUserById([FromQuery] string id)
        {
            User User = await this.UserGetService.getSingleItem(id);
            return Ok(User);
        }


        [HttpPost]
        [Route("~/insertUser")]
        public async Task<IActionResult> insertUser(UserInsertRequest insertUser)
        {
            User User = mapper.Map<User>(insertUser);

            bool id = await this.UserInsertService.insertSingleItem(User, "customer");
            return Ok(id);
        }

        

        [HttpPost]
        [Route("~/updateUser")]
        public async Task<IActionResult> updateUser(User User)
        {
            User updatedUser = await this.UserUpdateService.updateSingleItem(User);
            return Ok(updatedUser);
        }

        [HttpPost]
        [Route("~/deleteUser")]
        public IActionResult deleteSingleItem(User targetUser)
        {
            try
            {
                this.UserDeleteService.deleteSingleItem(targetUser);
                return Ok(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Ok(0);
            }
        }

        [HttpPost]
        [Route("~/registerNewUser")]
        public async Task<IActionResult> RegisterNewUser(UserInsertRequest insertUser)
        {
            //OrderDetail OrderDetail = mapper.Map<OrderDetail>(insertOrderDetail);
            User user = new User();
            bool result;
            if (ModelState.IsValid)
            {

                user.UserName = insertUser.Username;
                user.Email = insertUser.Email;
                user.Birthday = System.DateTime.Parse(insertUser.DateOfBirth);
                user.PasswordHash = Crypto.HashPassword(insertUser.Password);
                user.PhoneNumber = insertUser.Mobile;
                user.Address = insertUser.AddressLine1;
                user.City = insertUser.City;
                user.Country = insertUser.Country;
                
                result = await this.UserInsertService.insertSingleItem(user, "Customer");
                Console.WriteLine(insertUser.ToString());
                return Ok(insertUser);

            }
            else
            {
                //result = await insertUserState.AddinsertUserError("error", "input error");
                return Ok(insertUser); 
            }
            
        }

        [HttpPost]
        [Route("~/loginUser")]
        public async Task<IActionResult> loginUser(string userEmail, string Password)
        {
            if (ModelState.IsValid)
            {
                UserLogin userLogin= await this.UserAuthenticateService.authenticate(userEmail, Password);
                if(userLogin != null)
                {
                    var token = await this.userTokenHandlerService.createTokenAsync(userLogin);
                    return Ok(token);

                }
                return Ok("login failed");
            }
            return Ok("login failed");

        }

        [HttpPost]
        [Route("~/logoutUser")]
        public IActionResult logoutUser(string userEmail)
        {
            if (userEmail.Length>0)
            {
               var result=  this.UserAuthenticateService.logout(userEmail);
                
                return Ok(result);
            }
            return Ok("false");

        }




    }

}
