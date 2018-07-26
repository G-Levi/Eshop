using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eshop.Models
{
    public class Categories
    {
        [Key]
        public int Id { set; get; }

        public string Name { set; get; }

    }
}

