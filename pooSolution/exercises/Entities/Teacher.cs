using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class Teacher : Person
    {
        // hereda constructor
        public Teacher(string name, int age) : base(name, age)
        {

        }

        public string Explicar()
        {
           return "Estoy explicando";
        }
    }
}
