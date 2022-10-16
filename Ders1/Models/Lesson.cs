using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ders1.Models
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Ders Adı:")]
        public string LessonName { get; set; }
        [Required]
        [DisplayName("Öğretmen Adı:")]
        public string LessonTeacher { get; set; }
        [Required]
        [DisplayName("Ders Kodu")]
        public int LessonCode { get; set; }
    }
}
