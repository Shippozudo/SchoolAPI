using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class StudentAndLesson : Base<int>
    {
        //public StudentAndLesson()
        //{
        //    LessonName = new List<string?>();
        //}

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        //public List<string?> LessonName { get; set; }
        public string CourseName { get; set; }
        public string ClassName { get; set; }

    }
}
