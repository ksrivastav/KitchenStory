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
    public class ProductCategoryDTO
    {
        public int ProductCategoryId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public String tags { get; set; }

    }
}
