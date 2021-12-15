using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Discount
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long? Code { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int? MinPrice { get; set; }
        public int DiscountRate { get; set; }
    }
}
