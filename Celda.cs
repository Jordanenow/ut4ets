using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegazoCrack
{
   public  class Celda
    {

        public int tipo;
        public bolsa Bolsa;
    
      
        public Celda()
        {
            tipo = 0;

            Bolsa = null;
        }

        public virtual void Dibuja()
        {

            if (this.Bolsa != null)
            {
                if (this.Bolsa is platano)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("P");
                }
                else if (this.Bolsa is manzana)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("ó");
                }
                else if (this.Bolsa is salida)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("S");
                }
            }




            /* if (this.Bolsa.l == 0 && this.tipo == Material.Suelo){

                 this.Bolsa.dibuja();

             }*/

            else {
                switch (this.tipo)
                {
                    //Dibuja lo que seria en maa dependiendo del tipo de material que haya
                    case Material.Suelo:

                        Console.Write(" ");
                        break;

                    case Material.Agua:

                        Console.Write("|");
                        break;

                    case Material.Muro:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("█");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                        
                    case Material.bolsa:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("B");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case Material.salida:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("S");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;



                }

            }
        }

        public void putobjeto()
        {
            tipo = Material.bolsa;
           /*this.Bolsa.l = 0;*/

            
        }
        public bool Isobjeto()
        {
            if (tipo == Material.bolsa)
            {
                return true;
            }
            else
            {

                return false;
            }

        }
        public void Eraseobjeto()
        {
            tipo = Material.Suelo;
          

        }
    }
}
