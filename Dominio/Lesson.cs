using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Lesson : Base<int>
    {
        public string LessonName { get; set; }
        public int? idTeacher { get; set; }
    }
}
