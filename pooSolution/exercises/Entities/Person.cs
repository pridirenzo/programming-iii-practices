using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class Person
    {

        public string Name { get; set; }

        // constructor
        public Person(string name)
        {
            Name = name;
        }

        public string Introduce()
        {
            return $"Hola, mi nombre es {Name}!";
        }


    }
}
