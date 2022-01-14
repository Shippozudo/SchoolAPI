using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class StudentCourseClass : Base<int>
    {
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public int CourseId { get; set; }
        public int ClassId { get; set; }


    }
}
