using System.ComponentModel.DataAnnotations;

namespace Fiqh_Academy.Models
{
    public enum CourseType
    {
        Shahada, Lisan, Taleem
    }
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email Address")]
        [EmailAddress(ErrorMessage = "Please Enter in the Correct Format")]
        [Display(Name ="Email Address")]
        public string Email{ get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Fathers Name")]
        public string LName { get; set; }
        [Required]

        [Display(Name ="Mobile Number")]
        [Phone]
        public string Number { get; set; }
        [Required]
        [Display(Name ="Select Course")]
        public CourseType CourseType { get; set; }
    }
}