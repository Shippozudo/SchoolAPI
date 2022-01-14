using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class ClassAndCourseRepository : RepositoryBase<int , ClassAndCourse>, IClassAndCourseRepository
    {
        private readonly AppContext _classAndCourse;

        public ClassAndCourseRepository(AppContext context) : base(context)
        {
            _classAndCourse = context;
        }

        public void Delete(ClassAndCourse entity)
        {
            _classAndCourse.Set<ClassAndCourse>().Remove(entity);
        }

        public ClassAndCourse Find(int id)
        {
            return _classAndCourse.Set<ClassAndCourse>().Find(id);
        }

        public IEnumerable<ClassAndCourse> GetAll()
        {
            return _classAndCourse.Set<ClassAndCourse>().AsEnumerable();
        }

        public void Insert(ClassAndCourse entity)
        {
            _classAndCourse.Set<ClassAndCourse>().Add(entity);
        }

        public void Update(ClassAndCourse entity)
        {
            throw new NotImplementedException();
        }
    }
}
