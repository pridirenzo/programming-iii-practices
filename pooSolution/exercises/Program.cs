using System;
using System.Collections.Generic;

namespace exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
        }

        // ejercicio 1
        public static void Ejercicio1()
        {
            Console.WriteLine("Ingrese nombre 1: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre 2: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre 3: ");
            string name3 = Console.ReadLine();

            List<Person> people = new List<Person>();

            people.Add(new Person(name1, 20));
            people.Add(new Person(name2, 30));
            people.Add(new Person(name3, 40));

            foreach (Person person in people)
            {
                Console.WriteLine(person.Introduce());
            }
        }

        // ejercicio 2

        public static void Ejercicio2()
        {
            PhotoBook book = new PhotoBook();

            Console.WriteLine($"La cantidad de paginas es {book.GetTotalPages()}");

            PhotoBook book2 = new PhotoBook(24);

            Console.WriteLine($"La cantidad de paginas es {book2.GetTotalPages()}");

            BigPhotoBook bigBook = new BigPhotoBook();

            Console.WriteLine($"La cantidad de paginas es {bigBook.GetTotalPages()}");


        }


        // ejercicio 3

        public static void Ejercicio3()
        {
            // persona
            Person Priska = new Person("Priscila", 20);
            Console.WriteLine(Priska.Saludar());

            // estudiante
            Student Priscilita = new Student("Priskita", 20);
            Console.WriteLine(Priscilita.Saludar());
            Priscilita.SetEdad(20);
            Console.WriteLine(Priscilita.MostrarEdad());

            // profesor
            Teacher Priskaa = new Teacher("Priska", 20);
            Console.WriteLine(Priskaa.Saludar());
            Priskaa.SetEdad(20);
            Console.WriteLine(Priskaa.Explicar());

        
        }



    }
}