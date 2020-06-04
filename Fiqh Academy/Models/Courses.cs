using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Fiqh_Academy.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Course begin date")]
        public string Date { get; set; }
        [Required]
        [Display(Name = "Course duration")]
        public string Duration { get; set; }
        [Required]
        [Display(Name = "Timings")]
        public string Timings { get; set; }
    }
}