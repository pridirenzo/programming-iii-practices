using System;
using System.Collections.Generic;

namespace exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre 1: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre 2: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre 3: ");
            string name3 = Console.ReadLine();

            List <Person> people = new List<Person>();

            people.Add(new Person(name1));
            people.Add(new Person(name2));  
            people.Add(new Person(name3));

            foreach(Person person in people)
            {
                Console.WriteLine(person.Introduce());
            }

        }
    }
}