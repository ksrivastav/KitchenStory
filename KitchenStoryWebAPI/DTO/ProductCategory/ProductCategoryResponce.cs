using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace KitchenStoryWebAPI.DTO.ProductCategory
{
    public class ProductCategoryResponce
    {


        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string tags { get; set; }
       

    }
}
