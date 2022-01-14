using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Classroom : Base<int>
    {
        public int Name { get; set; }
        public int? idCourse { get; set; }
    }
}
