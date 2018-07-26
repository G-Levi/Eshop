using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
[Table("Category")]
    public class Category
    {
        [Key]//pt a se sti ca este cheie primara
        public int Id_Category { get; set; }//metoda

        [Required]
        [MaxLength(35)]
        public string Name { get; set; }
        
        public virtual ICollection<Item> Items { get; set; }

    }
}