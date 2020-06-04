using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Fiqh_Academy.Areas.Admin.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Your First Name")]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        [Display(Name = "First Name")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Type your Email Id")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(30, ErrorMessage = "Max 30 characters allowed")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        [MaxLength(20, ErrorMessage = "Max 40 characters allowed")]
        [MinLength(5, ErrorMessage = "Must be 5 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        [Display(Name = "Confirm Password")]
        [MaxLength(20, ErrorMessage = "Max 40 characters allowed")]
        [MinLength(5, ErrorMessage = "Must be 5 characters")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string CPassword { get; set; }
    }
}