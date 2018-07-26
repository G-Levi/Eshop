using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Eshop.Models
{
    public class Contact 
    {
        [Key] //Id declarat ca cheie primara
        public int Id_Contact { get; set; }

        [Required]//Necesar
        [StringLength(15,ErrorMessage = "FirstName must be 15 characters or less", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "LastName must be 15 characters or less", MinimumLength = 3)]
        public string LastName { get; set; }


        [Required]
        [RegularExpression(@"^(?<paren>\()?0(?:(?:72|74|75|76|77|78)(?(paren)\))(?<first>\d)(?!\k<first>{6})\d{6}|(?:251|351)(?(paren)\))(?<first>\d)(?!\k<first>{5})\d{5})$", ErrorMessage = "Invalid Phone number")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Message must be 300 characters or less", MinimumLength = 3)]
        public string Message { get; set; }
    }
}