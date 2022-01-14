using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class TeacherRepository : RepositoryBase<int, Teacher>, ITeacherRepository
    {
        private readonly AppContext _teacher;

        public TeacherRepository(AppContext context) : base(context)
        {
            _teacher = context;
        }

        public void Delete(Teacher entity)
        {
            _teacher.Set<Teacher>().Remove(entity);
        }

        public Teacher Find(int id)
        {
            return _teacher.Set<Teacher>().Find(id);
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _teacher.Set<Teacher>().AsEnumerable();
        }

        public void Insert(Teacher entity)
        {
            _teacher.Set<Teacher>().Add(entity);
        }

        public void Update(Teacher entity)
        {
            throw new NotImplementedException();
        }

    }
}
