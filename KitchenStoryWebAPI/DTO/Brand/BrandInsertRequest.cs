using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KitchenStoryWebAPI.DTO.ProductCategory;

namespace KitchenStoryWebAPI.DTO.Brand
{
    public class BrandInsertRequest
    {


        //public int ProductCategoryId { get; set; }
    //    [Required]
        public string Name { get; set; }

        //      [Required(ErrorMessage = "Please specify valid tags")]
        public bool isActiveFlag { get; set; }



    }
}
