using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryCore.DomainModel
{
    public class Order
    {
		[Key]
		//[Display(Name = "Order")]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderId{ get; set; }
		//public User user{ get; set; }
		public String Status{ get; set; }
		public double OrderAmount{ get; set; }
		public DateTime CreateDateTime{ get; set; }
		public DateTime UpdateDateTime{ get; set; }
		//public virtual User user { get; set; }

		public string userid { get; set; }

	}
}
