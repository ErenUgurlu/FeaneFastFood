using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public int? FoodId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        [NotMapped]
        public double TotalPrice
        { get { return Quantity * Price; } }
    }
}
