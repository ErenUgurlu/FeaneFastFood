using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.ViewModels
{
    public class OrderAndFoodListVM
    {
        public List<Food> Foods { get; set; }
        public Order Order { get; set; }
    }
}
