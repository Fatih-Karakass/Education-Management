using Ders1.Models.ModelMetaDataType;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders1.Models
{
    [ModelMetadataType(typeof(LessonMetaData))]
    public class Lesson
    {
        public int Id { get; set; }
        public string LessonName { get; set; }
        public string LessonTeacher { get; set; }
        public int LessonCode { get; set; }
    }
}
