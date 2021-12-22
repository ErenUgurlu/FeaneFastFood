using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public int TotalPrice { get; set; }
        public Guid? DiscountId { get; set; }
        [ForeignKey("DiscountId")]
        public Discount Discount { get; set; }
        public int? ShipmentPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public string OrderNote { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
    public enum City
    {
        Istanbul,
        Izmir,
        Eskisehir,
        Sakarya,
        Kocaeli,
        Bursa
    }
}

