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
    internal class ClassroomRepository : RepositoryBase<int, Classroom>, IClassroomRepository
    {
        public ClassroomRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public override void Delete(Classroom entity)
        {
            throw new NotImplementedException();
        }

        public override Classroom Find(int id)
        {
            return _connection.QuerySingle<Classroom>(
                @"SELECT
                    ID,
                    NOME,
                    CURSO_ID
                  FROM ""TURMA""
                  WHERE ID = :ID", new { id });
        }

        public override IEnumerable<Classroom> GetAll()
        {
            return _connection.Query<Classroom>(
                @"SELECT
                    ID,
                    NOME,
                    CURSO_ID
                  FROM TURMA");

        }

        public override void Insert(Classroom entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Classroom entity)
        {
            throw new NotImplementedException();
        }
    }
}
