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
    public class ClassAndCourseRepository : RepositoryBase<int, ClassAndCourse>, IClassAndCourseRepository
    {


        public ClassAndCourseRepository(IConfiguration configuration) : base(configuration)
        {

        }




        public override void Delete(ClassAndCourse entity)
        {
            throw new NotImplementedException();
        }

        public override ClassAndCourse Find(int id)
        {
            return _connection.QuerySingle<ClassAndCourse>(
               @"SELECT  
                    T.NOME AS TURMA,
                    C.NOME AS CURSO
                 FROM  TURMA T, CURSO C
                 WHERE C.ID = T.CURSO_ID
                 ORDER BY T.NOME ASC
                 WHERE ID = :ID", new { id });
        }

        public override IEnumerable<ClassAndCourse> GetAll()
        {
            return _connection.Query<ClassAndCourse>(
            @"SELECT  
                    T.NOME AS TURMA,
                    C.NOME AS CURSO
              FROM  TURMA T, CURSO C
              WHERE C.ID = T.CURSO_ID
              ORDER BY T.NOME ASC");
        }

        public override void Insert(ClassAndCourse entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(ClassAndCourse entity)
        {
            throw new NotImplementedException();
        }
    }
}
