using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace JuegazoCrack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicio

            bool menu = true;
            bool salir = false;
            
            //int x = 10, y = 10;
            Jugador dexter;
            dexter = new Jugador(400, 400);

            Requisitos normas;
            normas = new Requisitos();

            Mapa mapa;
            mapa = new Mapa(500, 500);
            mapa.jugador = dexter;

            mapa.RandomWalk(2000);
           /* mapa.RellenaRandom(70);*/
           // mapa.objetos(100);
            
            dexter.mapa = mapa;
            mapa.putobjetos(100);

            //Ponemos trampas
            mapa.putrampas(20);


            Console.CursorVisible = false;

            do
            {
                //Console.Clear();

                if (menu == true)
                {

                    if (File.Exists("../../data/Inicio.txt"))
                    {
                        StreamReader archivo;
                        String Contenido;

                        archivo = new StreamReader("../../data/Inicio.txt");
                        Contenido = archivo.ReadToEnd();
                        Console.WriteLine(Contenido);

                        ConsoleKeyInfo pantalla;
                        pantalla = Console.ReadKey(true);
                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    // portada 
                    Console.WriteLine("Bienvenido");
                    Console.WriteLine("1º - Jugar");
                    Console.WriteLine("X - Salir");

                    



                    ConsoleKeyInfo tecla;
                    tecla = Console.ReadKey(true);

                    if (tecla.Key == ConsoleKey.D1)
                    {
                        menu = false;
                    }
                    if (tecla.Key == ConsoleKey.X)
                    {
                        salir = false;
                    }
                    Console.Clear();
                }
              
                else
                {
              

                    // Jugando
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    // Console.WriteLine("Jugando...");

                    Console.SetCursorPosition(65, 3);
                    Console.Write("X=" + dexter.x + " ");

                    Console.SetCursorPosition(65, 5);
                    Console.Write("Y=" + dexter.y + " ");

                    int d = (int)Math.Sqrt(Math.Pow(dexter.x - mapa.endX, 2) + Math.Pow(dexter.y - mapa.endY, 2));
                    Console.SetCursorPosition(65, 4);
                    Console.Write( "Estas a "+d+ " pasos de la salida");

                    Console.SetCursorPosition(65, 18);
                    Console.Write("La condición de victorias es recoger, 5 plátanos ");
                    Console.SetCursorPosition(65, 19);
                    Console.Write("y 5 manzanas y luego usar la salida.");
                    Console.SetCursorPosition(65, 21);
                    Console.Write("Pero perderas si coges la salida antes");
                    Console.SetCursorPosition(65, 22);
                    Console.Write(" tener los requisitos. ");

                    mapa.Dibuja();

                    dexter.Dibuja();




                    ConsoleKeyInfo tecla;
                    tecla = Console.ReadKey(true);

                    switch (tecla.Key)
                    {
                        case ConsoleKey.M:
                            menu = true;
                            break;
                        case ConsoleKey.UpArrow:
                            dexter.Mueve("Arriba");

                            break;
                        case ConsoleKey.DownArrow:
                            dexter.Mueve("Abajo");
                            break;
                        case ConsoleKey.LeftArrow:
                            dexter.Mueve("izquierda");
                            break;
                        case ConsoleKey.RightArrow:
                            dexter.Mueve("Derecho");
                            break;
                    }
                    dexter.takeobjetos();
                }

               












            } while (salir == false);

        }
    }
}
        