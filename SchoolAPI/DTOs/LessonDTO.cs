using Exercicio_API_Biblioteca.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaAPI.DTOs
{
    public class LessonDTO : Validator
    {
        public int Id { get; set; }
        public string LessonName { get; set; }
        
        public int? idTeacher { get; set; }

        public override void Validar()
        {
            Valido = true;

            if (LessonName == "string" || LessonName == "")
                Valido = false;
        }
    }
}
