using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class ClassroomRepository : RepositoryBase<int, Classroom>, IClassroomRepository
    {

        private readonly AppContext _classroom;

        public ClassroomRepository(AppContext context) : base(context)
        {
            _classroom = context;
        }

        public void Delete(Classroom entity)
        {
            _classroom.Set<Classroom>().Remove(entity);
        }

        public Classroom Find(int id)
        {
            return _classroom.Set<Classroom>().Find(id);
        }

        public IEnumerable<Classroom> GetAll()
        {
            return _classroom.Set<Classroom>().AsEnumerable();
        }

        public void Insert(Classroom entity)
        {
            _classroom.Set<Classroom>().Add(entity);
        }

        public void Update(Classroom entity)
        {
            throw new NotImplementedException();
        }

    }
}
