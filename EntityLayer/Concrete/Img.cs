using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Img
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public Guid? FoodId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        public bool IsActive { get; set; }
    }
}
