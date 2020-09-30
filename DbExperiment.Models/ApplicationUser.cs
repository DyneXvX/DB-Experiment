using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExperiment.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string  FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string  LastName { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string  StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [Display(Name ="Postal Code")]
        public string PostalCode { get; set; }

        [NotMapped] 
        public string Role { get; set; }
    }
}
