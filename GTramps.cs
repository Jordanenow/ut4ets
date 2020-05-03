using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegazoCrack
{
    public class GTramps : Celda, ITrampas
    {

        // Las trampas tendran aspecto de platanos a drede
        public override void Dibuja()
        {
            Random r = new Random();
            int color = r.Next(2);

            switch (color)
            {
                case 1:
                Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("P");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("ó");
                    break;
            }
           
        }

        public int getpodrido()
        {
            return 2;
        }
    }
}