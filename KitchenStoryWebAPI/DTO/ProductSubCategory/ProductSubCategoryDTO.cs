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
    public class ProductSubCategoryDTO
    {

      
        public int ProductSubCategoryId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public String tags { get; set; }

        public virtual ProductCategoryDTO ProductCategory {get ; set ;}

    }
}
