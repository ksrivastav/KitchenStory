using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryWebAPI.DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        //public User user{ get; set; }
        public string Status { get; set; }
        public double OrderAmount { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        //public virtual User user { get; set; }

        public string userid { get; set; }

    }
}
