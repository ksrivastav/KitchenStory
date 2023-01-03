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
    public class ProductSubCategoryResponce
    {


        public int ProductSubCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string tags { get; set; }
        public virtual ProductCategoryResponce ProductCategoryResponce {get;set;}

    }
}
