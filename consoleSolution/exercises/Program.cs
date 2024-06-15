using System;


namespace Program
{


    public class Program
    {
        public static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
        }


        public static void Ejercicio1()
        {
            int x = 45;
            int y = 88;
            int z = 10;

            int total = x + y + z;

            Console.WriteLine(total);
        }

        public static void Ejercicio2()
        {

            Console.WriteLine("Nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ciudad: ");
            string city = Console.ReadLine();

            Console.WriteLine($"Hola {name}, bienvenido a {city} ");

        }
        

        public static void Ejercicio3()
        {
            Console.WriteLine("Nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Edad: ");
            string age = Console.ReadLine();
            int input = int.Parse(age);

            Console.WriteLine($"Hola, te llamas {name} y tu edad es {input}");
        }


        public static void Ejercicio4()
        {
            Console.WriteLine("Num1: ");
            string x = Console.ReadLine();
            Console.WriteLine("Num2: ");
            string y = Console.ReadLine();

            int inputX = int.Parse(x);
            int inputY = int.Parse(y);

            Console.WriteLine(Math.Max(inputX, inputY));
        }


        public static void Ejercicio5()
        {
            Console.WriteLine("Ingrese día: ");
            string day = Console.ReadLine();

            if (day.Contains("lunes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No es fin de semana");
            }
            else if (day.Contains("martes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No es fin de semana");
            }
            else if (day.Contains("miercoles", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No es fin de semana");
            }

            else if (day.Contains("jueves", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No es fin de semana");
            }

            else if (day.Contains("viernes", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No es fin de semana");
            }

            else if (day.Contains("sabado", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Fin de semana");
            }

            else if (day.Contains("domingo", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Fin de semana");
            }
            else
            {
                Console.WriteLine("Error, ingrese un día valido");
            }
                  
            }
        }


    }
  