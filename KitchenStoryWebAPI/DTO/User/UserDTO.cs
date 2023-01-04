using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace KitchenStoryWebAPI.DTO.Users
{
    public class UserDTO: IdentityUser
    {
        public UserDTO()
        {
        }
        //public virtual UserAddress UserAddress { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
