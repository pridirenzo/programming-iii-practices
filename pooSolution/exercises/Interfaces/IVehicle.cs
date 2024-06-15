using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public interface IVehicle
    {
        void Conducir();

        bool CargarCombustible(int cantidad);
    }
}
