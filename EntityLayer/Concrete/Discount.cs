using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public int? Name { get; set; }
        public long Code { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public double MinPrice { get; set; }
        public double DiscountRate { get; set; }
    }
}
