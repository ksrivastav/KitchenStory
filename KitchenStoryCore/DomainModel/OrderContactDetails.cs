using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenStoryCore.DomainModel
{
    public class OrderContactDetails
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }   
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public virtual  OrderAddress DeliveryAddress { get; set; }

        
    }
}
