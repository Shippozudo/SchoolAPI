using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class CourseRepository : RepositoryBase<int, Course>, ICourseRepository
    {

        private readonly AppContext _course;

        public CourseRepository(AppContext context) : base(context)
        {
            _course = context;
        }

        public void Delete(Course entity)
        {
            _course.Set<Course>().Remove(entity);
        }

        public Course Find(int id)
        {
            return _course.Set<Course>().Find(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return _course.Set<Course>().AsEnumerable();
        }

        public void Insert(Course entity)
        {
            _course.Set<Course>().Add(entity);
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
