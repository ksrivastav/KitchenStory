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
    public class ProductCategory
    {

        [Key]
        [Display(Name = "ProductCategory")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductCategoryId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public String tags { get; set; }

    }
}
