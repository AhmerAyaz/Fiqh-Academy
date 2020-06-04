using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Fiqh_Academy.Models
{
    public class Bayanaat
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please Enter Speaker's Name")]
        [Display(Name = "Speaker's Name")]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Speaker { get; set; }
        [Display(Name = "Topic")]
        [Required]
        public string Topic { get; set; }
        [Display(Name = "Audio Size")]
        [Required]
        public double? Size { get; set; }
        [Required]
        [Display(Name = "Upload Date")]
        public string Date { get; set; }
        [Required]
        [Display(Name = "File Path")]
        public string FilePath { get; set; }
        [NotMapped]
        public HttpPostedFileBase File { get; set; }
    }
}