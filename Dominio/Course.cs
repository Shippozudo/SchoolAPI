using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Course : Base<int>
    {
        public string Name { get; set; }
    }
}
