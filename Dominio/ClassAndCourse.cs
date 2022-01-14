using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ClassAndCourse : Base<int>
    {
        public int ClassName { get; set; }
        public string CourseName { get; set; }
    }
}
