using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class StudentAndLessonRepository : RepositoryBase<int, StudentAndLesson>, IStudentAndLessonRepository
    {
        private readonly AppContext _studentAndLesson;

        public StudentAndLessonRepository(AppContext context) : base(context)
        {
            _studentAndLesson = context;
        }

        public void Delete(StudentAndLesson entity)
        {
            _studentAndLesson.Set<StudentAndLesson>().Remove(entity);
        }

        public StudentAndLesson Find(int id)
        {
            return _studentAndLesson.Set<StudentAndLesson>().Find(id);
        }

        public IEnumerable<StudentAndLesson> GetAll()
        {
            return _studentAndLesson.Set<StudentAndLesson>().AsEnumerable();
        }

        public void Insert(StudentAndLesson entity)
        {
            _studentAndLesson.Set<StudentAndLesson>().Add(entity);
        }

        public void Update(StudentAndLesson entity)
        {
            throw new NotImplementedException();
        }

    }
}
