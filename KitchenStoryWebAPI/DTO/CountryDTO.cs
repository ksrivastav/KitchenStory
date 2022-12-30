using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KitchenStoryWebAPI.DTO
{
    public class CountryDTO
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public bool isActiveFlag { get; set; }
    }
}
