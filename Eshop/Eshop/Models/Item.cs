using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Item
    {
        [Key]
        public int Id_Item { get; set; }

        [Required]
        [MaxLength(35)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [MaxLength(15)]
        public string Producer { get; set; }

        [ForeignKey("Category")]
        public int Id_Category { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<Basket_Product> Basket_Products { get; set; }














    }
        
        
}