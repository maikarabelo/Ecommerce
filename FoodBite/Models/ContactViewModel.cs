using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBite.Models
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        [MaxLength(250)]
        public string Message { get; set; }
    }
}
