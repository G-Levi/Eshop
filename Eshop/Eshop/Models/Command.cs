using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Command
    {
        [Key] //Id declarat ca cheie primara
        public int Id { get; set; }
        [ForeignKey("Basket")]
        public int Id_Basket { get; set; }
        public int Id_User { get; set; }
    }
}