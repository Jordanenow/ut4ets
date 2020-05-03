using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegazoCrack
{
    class Jugador
    {
        public int x;
        public int y;
        Requisitos norma;
      
        public Mapa mapa;
        bool gameover = false;

        public Jugador(int x, int y)
        {
            this.x = x;
            this.y = y;
            norma = new Requisitos();
         

        }

        public void activar()
        {


             if (mapa.celdas[x, y] is GTramps)
            {
                if (norma.manzanitas >= (mapa.celdas[x, y] as GTramps).getpodrido()) {
                    norma.manzanitas = norma.manzanitas - (mapa.celdas[x, y] as GTramps).getpodrido();
                
                }
                else 
                {
                    norma.manzanitas = 0;
                }

                if (norma.platanitos >= (mapa.celdas[x, y] as GTramps).getpodrido())
                {
                    norma.platanitos = norma.platanitos - (mapa.celdas[x, y] as GTramps).getpodrido();
                }
                else { norma.platanitos = 0; }
                mapa.celdas[x, y] = new Celda();
            }
        }

        //Controles del jugadpr

        public void Mueve(String direc)
        {

            switch (direc)
            {
                case "Arriba":
                    if (this.y > 0 && this.mapa.celdas[x, y - 1].tipo == 0 || this.y > 0 && this.mapa.celdas[x, y - 1].tipo == 4)
                        y--;
                    activar();
                    break;
                case "Abajo":
                    if (this.y < 499 && this.mapa.celdas[x, y + 1].tipo == 0|| this.y < 499 && this.mapa.celdas[x, y + 1].tipo == 4)
                        y++;
                    activar();
                    break;
                case "izquierda":
                    if (this.x > 0 && this.mapa.celdas[x - 1, y].tipo == 0 || this.x > 0 && this.mapa.celdas[x - 1, y].tipo == 4)
                        x--;
                    activar();
                    break;
                case "Derecho":
                    if (this.x < 499 && this.mapa.celdas[x + 1, y].tipo == 0|| this.x < 499 && this.mapa.celdas[x + 1, y].tipo == 4 )
                        x++;
                    activar();
                    break;
            }


        }

        //Dibujamos al jugador

        public void Dibuja()
        {
            Console.SetCursorPosition(30, 10);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("M");

            Console.SetCursorPosition(65, 7);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Manzanas conseguidas = " + norma.manzanitas);

            Console.SetCursorPosition(65, 9);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Platanos conseguidas = " + norma.platanitos);

            
        }

        //El personaje coge el objeto
        public void takeobjetos()
        {
            if (mapa.celdas[x, y].Bolsa != null)
            {



                bool puedecoger;

                puedecoger = norma.TryAdd(mapa.celdas[x, y].Bolsa); // meto en la mochila

                if (puedecoger == true )
                {
                    if( mapa.celdas[x, y].Bolsa is platano)
                    {
                        norma.platanitos = norma.platanitos + 1;
                       
                    }
                    else if (mapa.celdas[x, y].Bolsa is manzana)
                    {
                        norma.manzanitas = norma.manzanitas + 1;

                    }
                    else if (mapa.celdas[x, y].Bolsa is salida && norma.platanitos >= 5 && norma.manzanitas >= 5)
                    {
                        ganar();
                    }

                        mapa.celdas[x, y].Bolsa = null; // quito del suelo
                }
            }


        }

        public void ganar()
        {
           
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(65, 11);
                Console.Write("Ganastes ");
            }
        }
    }
  
}
