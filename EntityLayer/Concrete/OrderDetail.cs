using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public Guid? FoodId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        public int ReducedPrice { get; set; }
        public int Quantity { get; set; }
    }
}
