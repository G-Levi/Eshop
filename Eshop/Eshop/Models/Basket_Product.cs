using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Basket_Product
    {
        [Key]
        [Column("Basket", Order=0)]
        [ForeignKey("Basket")]
        public int Id_Basket { get; set; }        
        public Basket Basket { get; set; }
      
        [Key]
        [Column("Item", Order = 1)]
        public int Id_Item { get; set; }
        public virtual Item Item { get; set; }

        public int Quantity { set; get; }

        public bool Stock { set; get; }

    }
}