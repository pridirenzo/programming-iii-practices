using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class StrengthCharacter : Character, IMove
    {
      public StrengthCharacter(string name, int strength, int agility, int magic)
        {
            Name = name;
            Strength = 100;
            Agility = agility;
            Magic = magic;

           

        }

        // implemento metodo abstracto base con OVERRIDE
      public override int CalcularDanio()
       {
            int damage = Agility * Magic * Strength;
            return damage;
       }

        public override string Atacar()
        {
            return $"{Name} hizo {Agility * Magic * Strength} de magia";
        }

        public string MoveX()
        {
            return $"Se movió en eje X";
        }

        public string MoveY()
        {
            return $"Se movió en eje Y";
        }

    }
}
