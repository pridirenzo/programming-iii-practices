using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class AgilityCharacter : Character, IMove
    {
        public AgilityCharacter(string name, int strenght, int magic, int agility) 
        { 
            Name = name;
            Strength = strenght;
            Magic = magic;
            Agility = agility;
        }

        public override int CalcularDanio()
        {
            int damage = (Strength / 2) * Agility * (Magic / 2);
            return damage;
        }


        public override string Atacar()
        {
            return $"{Name} hizo {(Strength / 2) * Agility * (Magic / 2)} de daño";
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
