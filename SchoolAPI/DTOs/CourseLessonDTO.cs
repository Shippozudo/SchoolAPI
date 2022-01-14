using Exercicio_API_Biblioteca.DTOs;
using System;
using System.Collections.Generic;

namespace SchoolAPI.DTOs
{
    public class CourseLessonDTO : Validator
    {
    
    
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid LessonId { get; set; }

        public override void Validar()
        {
            Valido = true;

        }

    }
}
