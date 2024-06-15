using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class Car : IVehicle
    {
        public int Combustible { get; set; }

        public Car(int cantidadInicial)
        {
            Combustible = cantidadInicial;

        }


        public bool CargarCombustible(int cantidad)
        {
            Combustible = cantidad;
            return true;
        }


        public void Conducir()
        {
            Console.WriteLine("Conduciendo...");

        }
    }
}
