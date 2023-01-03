using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KitchenStoryWebAPI.DTO.ProductCategory;

namespace KitchenStoryWebAPI.DTO.Order
{
    public class OrderInsertRequest
    {


        //public int OrderId { get; set; }
        //public User user{ get; set; }
        public String Status { get; set; }
        public double OrderAmount { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        //public virtual User user { get; set; }

        public string Userid { get; set; }



    }
}
