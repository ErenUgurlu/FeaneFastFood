using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid? FoodId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        [NotMapped]
        public double TotalPrice
        { get { return Quantity * Price; } }
    }
}
