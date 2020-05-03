using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegazoCrack
{
    class Mapa
    {
        public Celda[,] celdas;
        public int ancho, alto;
        public Jugador jugador;

        public int endX, endY;

        public Mapa(int x, int y)
        {
            this.ancho = x;
            this.alto = y;

            celdas = new Celda[ancho, alto];
            // Creando terreno
            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {
                    celdas[i, j] = new Celda();
                }

            }
            // Generando terreno
            Random r = new Random();
            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {

                    celdas[i, j].tipo = r.Next(0, 2);

                }
            }
        }
        //Dibuja el mapita

        public void Dibuja()
        {
            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int xx = i + this.jugador.x - 30 + 3, yy = j + this.jugador.y + 3 - 10;
                    Console.SetCursorPosition(i + 3, j + 3);
                    if (xx >= 0 && yy >= 0 && xx < this.ancho && yy < this.alto)
                    {
                        celdas[xx, yy].Dibuja();
                    }
                    else
                    {

                        Console.Write("|");
                    }

                }
            }
        }


        public void RandomWalk(int maxFloors)
        {
            // Random walk
            // position of walker
            int x, y;
            int floors;
            Random r = new Random();

            // initialize all map cells to walls. 
            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {
                    celdas[i, j].tipo = Material.Muro;
                    /* celdas[i, j].visible = false;*/
                }
            }
            // pick a map cell as the starting point. 
            x = ancho / 2;
            y = alto / 2;

            // turn the selected map cell into floor. 
            celdas[x, y].tipo = Material.Suelo;
            floors = 1;


            // while insufficient cells have been turned into floor,
            while (floors <= maxFloors)
            {

                //take one step in a random direction.
                int direction = r.Next(4);

                switch (direction)
                {
                    case 0:
                        x++;
                        break;
                    case 1:
                        x--;
                        break;
                    case 2:
                        y++;
                        break;
                    case 3:
                        y--;
                        break;
                }

                // comprobar si la x,y salen del mapa
                if (x < 0 || y < 0 || x >= ancho || y >= alto)
                {
                    x = ancho / 2;
                    y = alto / 2;
                }


                // if the new map cell is wall,
                //turn the new map cell into floor and increment the count of floor tiles. 
                if (celdas[x, y].tipo == Material.Muro)
                {
                    celdas[x, y].tipo = Material.Suelo;
                    floors++;
                }

            }

            jugador.x = ancho / 2;
            jugador.y = alto / 2;
        }

        public void RellenaRandom(int porcentaje)
        {
            Random r = new Random();

            int count = 0;
            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {

                    if (r.Next(0, 100) < porcentaje)
                    {

                        celdas[i, j].tipo = Material.Suelo;
                    }
                    else
                    {
                        celdas[i, j].tipo = Material.Muro;
                    }

                }
            }
        }
        /*public void objetos(int plat)
        {
            Random r = new Random();
            int count = 0;
            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {

                    if (r.Next(0, 100) < plat && celdas[i, j].tipo == Material.Suelo)
                    {
                        
                        celdas[i, j].tipo = Material.bolsa;
                    }
                }
            }
        }*/

        //Ponemos objetos en el mapa
        public void putobjetos(int valor)
        {
            int x;
            int y;
            Random r = new Random();
            for (int i = 0; i < valor; i++)
            {

                do
                {

                    x = r.Next(celdas.GetLength(0));
                    y = r.Next(celdas.GetLength(1));

                } while (celdas[x, y].tipo != Material.Suelo);

                if (r.Next(100) < 1)

                {
                    celdas[x, y].Bolsa = new salida();
                    endX = x;
                    endY = y;
                 
                }
                else if (r.Next(100) < 49)
                {
                    celdas[x, y].Bolsa = new manzana();
                }
                else if (r.Next(100) < 48)
                {
                    celdas[x, y].Bolsa = new platano();
                }
                //celdas[x, y].putobjeto();

            }

        }
        //Trampitas
        public void putrampas(int valor)
        {
            int x;
            int y;
            Random r = new Random();
            for (int i = 0; i < valor; i++)
            {

                do
                {

                    x = r.Next(celdas.GetLength(0));
                    y = r.Next(celdas.GetLength(1));

                } while (celdas[x, y].tipo != Material.Suelo);
                celdas[x, y] = new GTramps();

            }

        }

    }


}
