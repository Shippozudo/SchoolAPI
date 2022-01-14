using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class CourseLessonRepository : RepositoryBase<int, CourseLesson>, ICourseLessonRepository
    {
        private readonly AppContext _courseLesson;

        public CourseLessonRepository(AppContext context) : base(context)
        {
            _courseLesson = context;
        }

        public void Delete(CourseLesson entity)
        {
            _courseLesson.Set<CourseLesson>().Remove(entity);
        }

        public CourseLesson Find(int id)
        {
            return _courseLesson.Set<CourseLesson>().Find(id);
        }

        public IEnumerable<CourseLesson> GetAll()
        {
            return _courseLesson.Set<CourseLesson>().AsEnumerable();
        }

        public void Insert(CourseLesson entity)
        {
            _courseLesson.Set<CourseLesson>().Add(entity);
        }

        public void Update(CourseLesson entity)
        {
            throw new NotImplementedException();
        }

    }
}
