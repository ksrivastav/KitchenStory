using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryCore.DomainModel
{
    public class UserAddress
    {
        [Key]
        [Display(Name = "UserAddress")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAddressId { get; set; }
        public string AddressLine1;
        public string AddressLine2;
        public string PinCode;
        public virtual City City { get; set; }
        
    }
}
