using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiqh_Academy.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please Enter Speaker's Name")]
        [Display(Name = "Author")]
        [MaxLength(40, ErrorMessage = "Max 40 char allowed")]
        public string Speaker { get; set; }
        [Display(Name = "Topic")]
        [Required]
        public string Topic { get; set; }
        [Display(Name = "Size")]
        [Required]
        public double? Size { get; set; }
        [Required]
        [Display(Name = "Upload Date")]
        public string Date { get; set; }
        [Required]
        public byte[] FileContent { get; set; }
        [NotMapped]
        public HttpPostedFileBase Files { get; set; }
    }
}