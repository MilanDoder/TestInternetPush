using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomskiRad.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Full Name")]
        public string Name { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        public string PhoneNumber { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Address { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
