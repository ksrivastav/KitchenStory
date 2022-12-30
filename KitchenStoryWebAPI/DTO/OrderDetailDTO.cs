using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryWebAPI.DTO
{
    public class OrderDetailDTO
    {
        public int OrderDetailId { get; set; }

        public ProductDTO Product { get; set; }
        public double ProductPricePaid { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int Quantity { get; set; }

        public virtual OrderDTO Order { get; set; }
    }
}
