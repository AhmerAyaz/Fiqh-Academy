using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Fiqh_Academy.Models
{
    public enum ContactType
    {
        Text, WhatsApp, Email
    }
    public class Update
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please Enter Your Name")]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Name { get; set; }
        [Display(Name = "Mobile Number")]
        [Required]
        public string Number { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contact Type")]
        public ContactType ContactType { get; set; }
    }
}