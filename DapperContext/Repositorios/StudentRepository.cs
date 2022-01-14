using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dominio;
using Microsoft.Extensions.Configuration;

namespace DapperContext.Repositorios
{
    public class StudentRepository : RepositoryBase<int, Student>, IStudentRepository
    {

        public StudentRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public override void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public override Student Find(int id)
        {
            return _connection.QuerySingle<Student>(
                @"SELECT
                    NOME
                  FROM ALUNOS
                  WHERE ID = :ID", new { id });
        }

        public override IEnumerable<Student> GetAll()
        {
            return _connection.Query<Student>(
                @"SELECT
                    ID,
                    NOME
                  FROM ALUNOS");
        }

        public override void Insert(Student entity)
        {
            //_connection.Execute(
            //    @"INSERT INTO ALUNOS
            //        (ID, NOME)
            //      VALUES
            //        (:ID, :NAME)", entity);
            throw new NotImplementedException();
        }

        public override void Update(Student entity)
        {
            throw new NotImplementedException();
        }

    }
}
