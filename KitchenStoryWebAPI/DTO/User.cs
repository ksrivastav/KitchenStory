using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity.EntityFramework;


namespace KitchenStoryWebAPI.DTO
{
    public class User //: //IdentityUser
    {
        public User()
        {
        }
        //public virtual UserAddress UserAddress { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
