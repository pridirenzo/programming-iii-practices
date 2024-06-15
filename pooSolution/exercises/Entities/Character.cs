using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public abstract class Character
    {

       public string Name { get; set; }
       public int Strength {  get; set; }

       public int Agility { get; set; }
       public int Magic { get; set; }

       public abstract int CalcularDanio();

       public abstract string Atacar();

       

    }
}
