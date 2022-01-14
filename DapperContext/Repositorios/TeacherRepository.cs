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
    public class TeacherRepository : RepositoryBase<int, Teacher>, ITeacherRepository
    {

        public TeacherRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public override void Delete(Teacher entity)
        {
            throw new NotImplementedException();
        }

        public override Teacher Find(int id)
        {
            return _connection.QuerySingle<Teacher>(
               @"SELECT
                    NOME
                    FROM PROFESSOR
                WHERE ID = :ID", new { id });
        }

        public override IEnumerable<Teacher> GetAll()
        {
            return _connection.Query<Teacher>(
              @"SELECT
                    ID,
                    NOME
                    FROM PROFESSOR");
        }

        public override void Insert(Teacher entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Teacher entity)
        {
            throw new NotImplementedException();
        }
    }
}
