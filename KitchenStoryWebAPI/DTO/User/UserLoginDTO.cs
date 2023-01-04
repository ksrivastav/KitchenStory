using KitchenStoryWebAPI.DTO.Users;

namespace KitchenStoryWebAPI.DTO.Users
{
    public class UserLoginDTO
    {
        public UserDTO user { get; set; }
        public IList<String> Roles { get; set; }

    }
}
