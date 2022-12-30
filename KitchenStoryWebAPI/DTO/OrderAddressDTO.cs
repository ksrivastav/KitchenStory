using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryWebAPI.DTO
{
    public class OrderAddressDTO
    {

        public int OrderAddressId { get; set; }
        public virtual OrderDTO Order { get; set; }
        public string AddressLine1;
        public string AddressLine2;
        public string PinCode;
        public virtual CityDTO City { get; set; }




    }
}
