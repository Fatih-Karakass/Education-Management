<<<<<<< HEAD:Models/Models/Lesson.cs
﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
=======
﻿using Ders1.Models.ModelMetaDataType;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 57ebb3517db82bba8f200473a5f68fcdc577c6d2:Ders1/Models/Lesson.cs
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders1.Models
{
    [ModelMetadataType(typeof(LessonMetaData))]
    public class Lesson
    {
<<<<<<< HEAD:Models/Models/Lesson.cs

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
=======
       
        public int Id { get; set; }

        public string LessonName { get; set; }
        
       
        public string LessonTeacher { get; set; }
       
>>>>>>> 57ebb3517db82bba8f200473a5f68fcdc577c6d2:Ders1/Models/Lesson.cs
        public int LessonCode { get; set; }
    }
}
