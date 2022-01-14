using Exercicio_API_Biblioteca.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaAPI.DTOs
{
    public class ClassroomDTO : Validator
    {

        public int  Id { get; set; }
        public int Name { get; set; }
        public int? idCourse { get; set; }

        public override void Validar()
        {
            Valido = true;

            if (Name == 0 )
                Valido = false;

            if (Name < 100 || Name > 199)
                Valido = false;
            
            
        }
    }
}
