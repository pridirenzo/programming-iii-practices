using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class Student : Person
    {
        // constructor hereda de constructor de person.
        public Student(string name, int age) : base(name, age)
        {
        }

        public string Estudiar()
        {
            return "Estoy estudiando";
    
        }
    }
}
