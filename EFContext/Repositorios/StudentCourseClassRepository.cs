using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class StudentCourseClassRepository : RepositoryBase<int, StudentCourseClass>, IStudentCourseClassRepository
    {
        public StudentCourseClassRepository(AppContext context) : base(context)
        {




            // Essa entidade studentCouseClass implementa o registrar materia, regista materia um por um;
            //Porém pro find e findall tem que usar outra entidade que tem a lista de materias, pra quando der o get pegar a lista de materias


        }
    
    }
}
