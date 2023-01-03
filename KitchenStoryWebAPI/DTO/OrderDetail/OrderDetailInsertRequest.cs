using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KitchenStoryWebAPI.DTO.ProductSubCategory;

namespace KitchenStoryWebAPI.DTO.OrderDetail
{
    public class OrderDetailInsertRequest
    {


        public int ProductId { get; set; }
        public double ProductPricePaid { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int Quantity { get; set; }

        public  int OrderId { get; set; }




    }
}
