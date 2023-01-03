using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KitchenStoryWebAPI.DTO.ProductSubCategory;

namespace KitchenStoryWebAPI.DTO.Product
{
    public class ProductInsertRequest
    {
		
		
		public String Name{ get; set; }

	
		public String Tag{ get; set; }
		public String Color{ get; set; }
		public double Price{ get; set; }
		public DateTime CreateDateTime{ get; set; }
		public DateTime UpdateDateTime{ get; set; }
		public String Image{ get; set; }
		public string Gender { get; set; }
		
		public  int ProductSubCategoryId { get; set; }
		public  virtual int BrandId { get; set; }
		



	}
}
