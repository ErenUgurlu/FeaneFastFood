using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int? FoodId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
