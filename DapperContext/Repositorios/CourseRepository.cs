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
    public class CourseRepository : RepositoryBase<int, Course>, ICourseRepository
    {

        public CourseRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public override void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public override Course Find(int id)
        {
            return _connection.QuerySingle<Course>(
                @"SELECT
                        ID,
                        NOME
                  FROM 
                        CURSO
                  WHERE ID = :ID", new { id });
        }

        public override IEnumerable<Course> GetAll()
        {
            return _connection.Query<Course>(
                @"SELECT
                    ID,
                    NOME
                  FROM CURSO");
        }

        public override void Insert(Course entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
