<<<<<<< HEAD:Models/Models/Teacher.cs
﻿using System.ComponentModel;
=======
﻿using Ders1.Models.MetaDataType;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
>>>>>>> 57ebb3517db82bba8f200473a5f68fcdc577c6d2:Ders1/Models/Teacher.cs
using System.ComponentModel.DataAnnotations;

namespace Ders1.Models
{
    [ModelMetadataType(typeof(TeacherMetaData))]
    public class Teacher
    {
        // primary key
        
        public int Id { get; set; }

       
        public string Name { get; set; }

<<<<<<< HEAD:Models/Models/Teacher.cs
        [Required (ErrorMessage = "Email Adresi Boş bırakılmamalıdır.")]
        [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir Mail Gİriniz.")]
=======
    
>>>>>>> 57ebb3517db82bba8f200473a5f68fcdc577c6d2:Ders1/Models/Teacher.cs
        public string Email { get; set; }

      
        public int Age { get; set; }

        public string? Address { get; set; }
        // nullable - null olabilir.

    }
}
