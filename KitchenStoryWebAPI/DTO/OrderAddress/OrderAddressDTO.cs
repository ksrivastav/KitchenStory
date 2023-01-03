using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KitchenStoryWebAPI.DTO.Order;

namespace KitchenStoryWebAPI.DTO.OrderAddress
{
    public class OrderAddressDTO
    {

        public int OrderAddressId { get; set; }
        public virtual OrderDTO Order { get; set; }
     
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PinCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }




    }
}
