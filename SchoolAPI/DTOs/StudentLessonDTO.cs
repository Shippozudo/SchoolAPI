using Exercicio_API_Biblioteca.DTOs;
using System;

namespace SchoolAPI.DTOs
{
    public class StudentLessonDTO : Validator
    {


        
        public Guid StudentId { get; set; }
        public Guid LessonId { get; set; }
        public Guid ClassId { get; set; }
        public Guid CourseId { get; set; }


        public override void Validar()
        {
            Valido = true;
            
            if(StudentId == Guid.Empty)
                Valido = false;

            if (ClassId == Guid.Empty)
                Valido = false;

            if (CourseId == Guid.Empty)
                Valido = false; 


        }
    }
}
