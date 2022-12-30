using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryCore.DomainModel
{
    public class Product
    {
		[Key]
		[Display(Name = "Product")]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductId{ get; set; }
		public String Name{ get; set; }

	
		public String Tag{ get; set; }
		public String Color{ get; set; }
		public double Price{ get; set; }
		public DateTime CreateDateTime{ get; set; }
		public DateTime UpdateDateTime{ get; set; }
		public String Image{ get; set; }
		public string Gender { get; set; }
		
		public  virtual ProductCategory ProductCategory { get; set; }
		public  virtual Brand brand { get; set; }
		



	}
}
