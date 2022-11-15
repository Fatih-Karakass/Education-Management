using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ders1.Models.MetaDataType
{
    public class TeacherMetaData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("İsim")]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Range(1, 100)]
        [DisplayName("Yaş")]
        public int Age { get; set; }
    }
}
