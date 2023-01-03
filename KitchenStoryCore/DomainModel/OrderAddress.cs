﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryCore.DomainModel
{
    public class OrderAddress
    {
        [Key]
        [Display(Name = "OrderAddress")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderAddressId { get; set; }
        public virtual Order Order { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PinCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }




    }
}
