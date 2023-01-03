using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KitchenStoryWebAPI.DTO.ProductCategory;

namespace KitchenStoryWebAPI.DTO.ProductSubCategory
{
    public class ProductSubCategoryInsertRequest
    {


        //public int ProductCategoryId { get; set; }
    //    [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

  //      [Required(ErrorMessage = "Please specify valid tags")]
        public string tags { get; set; }
        [Required]

//        [Range(0, int.MaxValue, ErrorMessage ="Please specify valid integer value")]
        public int ProductCategoryId {get;set;}

    }
}
