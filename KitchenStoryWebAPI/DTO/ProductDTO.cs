using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryWebAPI.DTO
{
    public class ProductDTO
    {

        public int ProductId { get; set; }
        public string Name { get; set; }


        public string Tag { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string Image { get; set; }
        public string Gender { get; set; }

        public virtual ProductCategoryDTO ProductCategory { get; set; }
        public virtual BrandDTO brand { get; set; }




    }
}
