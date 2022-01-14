using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CourseLesson : Base<int>
    {
        //public CourseLesson()
        //{
        //    Lesson = new List<string>();
        //}

        public int? CourseId { get; set; }
        public string Course { get; set; }
        //public List<string?> Lesson { get; set; }
    }
}
