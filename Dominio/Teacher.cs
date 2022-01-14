using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Teacher : Base<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
