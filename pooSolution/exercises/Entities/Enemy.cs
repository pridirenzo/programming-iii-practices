using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class Enemy : IMove
    {

        public int Health { get; set; }
        public int Level { get; set; }

        public Enemy(int health, int level)
        {
            Health = health;
            Level = level;
        }

        public string MoveX()
        {
            return $"Enemigo se movió en eje X";
        }

        public string MoveY()
        {
            return $"Enemigo se movió en eje Y";
        }


    }
}
