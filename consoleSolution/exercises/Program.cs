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
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();
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


        public static void Ejercicio6()
        {

            Console.WriteLine("Ingrese precio de producto: ");
            string price = Console.ReadLine();
            double floatPrice = double.Parse(price);
            Console.WriteLine("Ingrese medio de pago: 1-EFECTIVO, 2-TARJETA");
            string paymentMethod = Console.ReadLine();
            int paymentNumber = int.Parse(paymentMethod);
            Console.WriteLine("Ingrese num de tarjeta: ");
            string num = Console.ReadLine();
            // precio final
            floatPrice = floatPrice + (floatPrice * 0.10);

            if (num.Length == 16)
            {
                Console.WriteLine($"Precio final a pagar: {floatPrice}");
            }

        }

        public static void Ejercicio7()
        {
            for (int x = 0; x <= 100; x++)
            {
                Console.WriteLine(x);
            }


        }

        public static void Ejercicio8()
        {
            int x = 0;
            while (x <= 100)
            {
                Console.WriteLine(x);
            }
        }

        public static void Ejercicio9()
        {
            for (int x = 0; x <= 100; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }

        public static void Ejercicio10()
        {
            List<int> evenNumbers = new List<int>();
            List<int> dividedByThree = new List<int>();

            for (int x = 0; x <= 100; x++)
            {
                if (x % 2 == 0)
                {
                    evenNumbers.Add(x);
                }
                else if (x % 3 == 0)
                {
                    dividedByThree.Add(x);
                }

            }

            Console.WriteLine("Numeros pares: ");
            for (int i = 0; i <= evenNumbers.Count; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Numeros divisibles por 3: ");
            for (int k = 0; k <= dividedByThree.Count; k++)
            {
                Console.WriteLine(k);

            }

        }

    }
}
  