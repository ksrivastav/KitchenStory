using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KitchenStoryWebAPI.DTO.OrderContactDetail;
using KitchenStoryWebAPI.DTO.Brand;
using KitchenStoryCore.DomainModel;
using KitchenStoryWebAPI.DTO.Order;
using KitchenStoryWebAPI.DTO.OrderAddress;

namespace KitchenStoryWebAPI.DTO.OrderContactDetail
{
    public class OrderContactDetailDTO
    {

        public int OrderContactDetailId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public OrderDTO Order{ get; set; }





    }
}
