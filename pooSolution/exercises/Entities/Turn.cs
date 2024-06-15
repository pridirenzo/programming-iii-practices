using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public static class Turn
    {
        
        public static void Attack(List<Character> characters)
        {

            foreach (Character character in characters)
            {
                Console.WriteLine(character.Atacar());
            }

        
        }


        public static void MovePlaces(IMove ficha)
        {
            ficha.MoveX();
            ficha.MoveY();
        }

    }
}
