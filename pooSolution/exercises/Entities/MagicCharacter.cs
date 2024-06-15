using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class MagicCharacter : Character, IMove
    {
        public MagicCharacter(string name, int strength, int magic, int agility)
        {
            Name = name;
            Strength = strength;
            Magic = magic;
            Agility = agility;
        }


        /* public MagiccCharacter(string name, int strength, int magic)
        {
            Name = name;
            Strength = strength;
            Magic = 60;
    
        }
        */

        public override int CalcularDanio()
        {   
            int damage = Strength + Agility + Magic * 4;
            return damage;
        }

        public override string Atacar()
        {
            return $"{Name} hizo {Strength + Agility + Magic * 4} de daño gracias a su magia";
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
