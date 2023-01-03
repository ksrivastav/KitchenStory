using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KitchenStoryWebAPI.DTO.ProductSubCategory;
using KitchenStoryWebAPI.DTO.Brand;

namespace KitchenStoryWebAPI.DTO.Product
{
    public class ProductDTO
    {
		
		public int ProductId{ get; set; }
		public String Name{ get; set; }

	
		public String Tag{ get; set; }
		public String Color{ get; set; }
		public double Price{ get; set; }
		public DateTime CreateDateTime{ get; set; }
		public DateTime UpdateDateTime{ get; set; }
		public String Image{ get; set; }
		public string Gender { get; set; }
		
		public  virtual ProductSubCategoryDTO ProductSubCategory { get; set; }
		public  virtual BrandDTO brand { get; set; }
		



	}
}
