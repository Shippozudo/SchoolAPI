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
    public class CourseLessonRepository : RepositoryBase<int, CourseLesson>, ICourseLessonRepository
    {
        public CourseLessonRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public override void Delete(CourseLesson entity)
        {
            throw new NotImplementedException();
        }

        public override CourseLesson Find(int id)
        {
            return _connection.QuerySingle<CourseLesson>(
                @"SELECT 
                        M.NOME AS Materia
                  FROM 
                        CURSO_MATERIA CM
                        JOIN CURSO C
                        ON C.ID = CM.ID_CURSO
                        JOIN MATERIA M
                        ON M.ID = CM.ID_MATERIA
                        WHERE CM.ID_CURSO = :ID", new { id });
        }

        public override IEnumerable<CourseLesson> GetAll()
        {
            return _connection.Query<CourseLesson>(
               @"SELECT 
                        M.NOME AS Materia
                  FROM 
                        CURSO_MATERIA CM
                        JOIN CURSO C
                        ON C.ID = CM.ID_CURSO
                        JOIN MATERIA M
                        ON M.ID = CM.ID_MATERIA");
        }

        public override void Insert(CourseLesson entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(CourseLesson entity)
        {
            throw new NotImplementedException();
        }
    }
}
