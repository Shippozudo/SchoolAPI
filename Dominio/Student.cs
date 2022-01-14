using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Student : Base<int>
    {
        public string Name { get; set; }
        public int? IdClassroom { get; set; }
        public int? IdCourse { get; set; }

    }
}
