using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryCore.DomainModel
{
   public  class OrderDetail
    {
		[Key]
		[Display(Name = "Orderdetails")]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderDetailId{ get; set; }
		
		public Product Product{ get; set; }
		public double ProductPricePaid{ get; set; }
		public DateTime CreateDateTime{ get; set; }
		public DateTime UpdateDateTime{ get; set; }
		public int Quantity{ get; set; }

		public virtual Order Order { get; set; }
	}
}
