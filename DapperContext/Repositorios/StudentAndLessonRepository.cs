using Dominio;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperContext.Repositorios
{
    public class StudentAndLessonRepository : RepositoryBase<int, StudentAndLesson>, IStudentAndLessonRepository
    {

        public StudentAndLessonRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public override void Delete(StudentAndLesson entity)
        {
            throw new NotImplementedException();
        }

        public override StudentAndLesson Find(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<StudentAndLesson> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Insert(StudentAndLesson entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(StudentAndLesson entity)
        {
            throw new NotImplementedException();
        }
    }

    
    
}
