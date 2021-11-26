using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public double? TotalPrice { get; set; }
        public double? Discount { get; set; }
        public double? ShipmentPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Payment Payment { get; set; }

    }
    public enum OrderStatus
    {
        Preparing,
        Shipped,
        Delivered
    }
    public enum Payment
    {
        CreditCard,
        EFT,
        Remittance,
        PayAtTheDoor,
        PaymentFailed
    }
}

