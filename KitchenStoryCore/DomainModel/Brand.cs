using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryCore.DomainModel
{
    public class Brand
    {
        [Key]
        [Display(Name = "Brand")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId{get;set;}
        public String Name{get;set;}
        public DateTime CreateDateTime{get;set;}
        public DateTime UpdateDateTime{get;set;}
        public bool isActiveFlag{get;set;}
    }
}
