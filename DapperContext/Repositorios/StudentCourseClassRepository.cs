using Dapper;
using Dominio;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperContext.Repositorios
{
    public class StudentCourseClassRepository : RepositoryBase<int, StudentCourseClass>, IStudentCourseClassRepository
    {

        public StudentCourseClassRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public override void Delete(StudentCourseClass entity)
        {
            throw new NotImplementedException();
        }

        public override StudentCourseClass Find(int id)
        {
            return _connection.QuerySingle<StudentCourseClass>(
                @"SELECT 
                        A.ID AS ID_ALUNO, 
                        A.NOME AS Aluno, 
                        C.NOME AS Curso, 
                        T.NOME AS Turma 
                  FROM 
                        ALUNOS A, 
                        CURSO C,
                        TURMA T
                  WHERE A.TURMA_ID = T.ID AND A.CURSO_ID = C.ID
                  WHERE ID_ALUNO = :ID ", new { id });

        }

        public override IEnumerable<StudentCourseClass> GetAll()
        {
            return _connection.Query<StudentCourseClass>(
                @"SELECT 
                        A.ID AS id_aluno, 
                        A.NOME AS Aluno, 
                        C.NOME AS Curso, 
                        T.NOME AS Turma 
                  FROM 
                        ALUNOS A, 
                        CURSO C, 
                        TURMA T
                  WHERE 
                        A.TURMA_ID = T.ID AND A.CURSO_ID = C.ID");
        }

        public override void Insert(StudentCourseClass entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(StudentCourseClass entity)
        {
            throw new NotImplementedException();
        }
    }
}
