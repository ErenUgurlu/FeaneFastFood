using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Food
    {
        public Food()
        {
            InCartQuantity = 1;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsInStock { get; set; }
        public string Detail { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string ImgPath { get; set; }
        [NotMapped]
        public int InCartQuantity { get; set; }
    }
}
