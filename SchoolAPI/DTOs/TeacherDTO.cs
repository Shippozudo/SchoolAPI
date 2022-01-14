using Exercicio_API_Biblioteca.DTOs;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaAPI.DTOs
{
    public class TeacherDTO : Validator
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public override void Validar()
        {
            Valido = true;

            if(Name == "string" || Name == "" )
                Valido = false;
            
        }
    }
}
