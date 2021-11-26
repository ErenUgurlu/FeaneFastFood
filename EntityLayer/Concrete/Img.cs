using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Models
{
    public class Img
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public int? FoodId { get; set; }
        [ForeignKey("FoodId")]
        public Food Food { get; set; }
        public bool IsActive { get; set; }
    }
}
