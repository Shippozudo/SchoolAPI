using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class StudentRepository : RepositoryBase<int, Student>, IStudentRepository
    {

        private readonly AppContext _students;

        public StudentRepository(AppContext context) : base(context)
        {
            _students = context;
        }

        public void Delete(Student entity)
        {
            _students.Set<Student>().Remove(entity);
        }

        public Student Find(int id)
        {
            return _students.Set<Student>().Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _students.Set<Student>().AsEnumerable();
        }

        public void Insert(Student entity)
        {
            _students.Set<Student>().Add(entity);
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }

    }
}
