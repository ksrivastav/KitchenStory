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
    public class ProductSubCategory
    {

        [Key]
        [Display(Name = "ProductSubCategory")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSubCategoryId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public String tags { get; set; }

        public virtual ProductCategory ProductCategory {get ; set ;}

    }
}
