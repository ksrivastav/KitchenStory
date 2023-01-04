

namespace KitchenStoryCore.DomainModel
{
    public class UserLogin
    {
        public User user { get; set; }
        public IList<String> Roles { get; set; }

    }
}
