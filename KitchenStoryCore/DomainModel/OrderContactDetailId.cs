using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KitchenStoryCore.DomainModel
{
    public class OrderContactDetail
    {
        [Key]
        [Display(Name = "OrderContactDetail")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderContactDetailsId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }   
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public virtual  OrderAddress DeliveryAddress { get; set; }

        
    }
}
