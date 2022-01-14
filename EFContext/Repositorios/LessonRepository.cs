using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFContext.Repositorios
{
    public class LessonRepository : RepositoryBase<int, Lesson>, ILessonRepository
    {

        private readonly AppContext _lesson;

        public LessonRepository(AppContext context) : base(context)
        {
            _lesson = context;
        }

        public void Delete(Lesson entity)
        {
            _lesson.Set<Lesson>().Remove(entity);
        }

        public Lesson Find(int id)
        {
            return _lesson.Set<Lesson>().Find(id);
        }

        public IEnumerable<Lesson> GetAll()
        {
            return _lesson.Set<Lesson>().AsEnumerable();
        }

        public void Insert(Lesson entity)
        {
            _lesson.Set<Lesson>().Add(entity);
        }

        public void Update(Lesson entity)
        {
            throw new NotImplementedException();
        }
    }
}
