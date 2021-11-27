using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Discount
    {
        public Guid Id { get; set; }
        public int? Name { get; set; }
        public long Code { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public double MinPrice { get; set; }
        public double DiscountRate { get; set; }
    }
}
