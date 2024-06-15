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
        public int Age { get; set; }

        // constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Introduce()
        {
           return $"Hola, mi nombre es {Name}!";
        }

        public string Saludar()
        {
            return "Hola!";
        }

        public void SetEdad(int age)
        {
            Age = age;
    
        }

        public string MostrarEdad()
        {
            return $"Mi edad es: {Age}";
        }


    }
}
