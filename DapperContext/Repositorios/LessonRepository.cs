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
    public class LessonRepository : RepositoryBase<int, Lesson>, ILessonRepository
    {
        public LessonRepository(IConfiguration configuration) : base(configuration)
        {
                
        }

        public override void Delete(Lesson entity)
        {
            throw new NotImplementedException();
        }

        public override Lesson Find(int id)
        {
            return _connection.QuerySingle<Lesson>(
                @"SELECT
                        NOME
                        PROFESSOR_ID
                 FROM 
                        MATERIA
                 WHERE ID = :ID", new { id });
        }

        public override IEnumerable<Lesson> GetAll()
        {
            return _connection.Query<Lesson>(
                @"SELECT
                        NOME,
                        PROFESSOR_ID
                  FROM MATERIA");
        }

        public override void Insert(Lesson entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Lesson entity)
        {
            throw new NotImplementedException();
        }
    }
}
