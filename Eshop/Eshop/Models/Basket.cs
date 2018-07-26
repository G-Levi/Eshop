using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Basket
    {
        [Key]
        public int Id_Basket { get; set; }

        public bool Condition { get; set; }

        public DateTime Update_Data { get; set; }

        public decimal Total_Price { get; set; }

        public virtual ICollection<Basket_Product>Basket_products{ get; set; }

    }
}