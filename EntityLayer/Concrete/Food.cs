using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FeaneFastFood.Models
{
    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsInStock { get; set; }
        public string Detail { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
