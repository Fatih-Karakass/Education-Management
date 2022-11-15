using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders1.Models
{
    public class Lesson
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Ders Adı:")]
        public string LessonName { get; set; }

        
        [ForeignKey("TeacherId")]
        [ValidateNever]
        public Teacher Teacher { get; set; }

        [Required]
        public int TeacherId { get; set; }

        [Required]
        [DisplayName("Ders Kodu")]
        public int LessonCode { get; set; }
    }
}
