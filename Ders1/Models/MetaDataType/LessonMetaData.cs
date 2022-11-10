using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ders1.Models.ModelMetaDataType
{
    public class LessonMetaData
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
