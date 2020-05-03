using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegazoCrack
{
    class Requisitos
    {
        public List<bolsa> items;
        public int itemIndex;
        public int platanitos;
        public int manzanitas;

        public Requisitos()
        {
            itemIndex = -1;
            items = new List<bolsa>();
              platanitos = 0;
             manzanitas = 0;

        }

        public void Display()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i != itemIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.SetCursorPosition(42, 6 + i);
                items[i].Display();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(42, 6 + items.Count);
            Console.Write("               ");

        }
        public bool TryAdd(bolsa objeto)
        {
            if (items.Count < 1000000)
            {
                items.Add(objeto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SelectItem(int numeroItem)
        {

            itemIndex = numeroItem;
        }


        public bool UseItem()
        {
           
            if (itemIndex != -1)
            {
                bolsa objeto = items[itemIndex];

                if (items is platano)
                {
                    platanitos++;
                    return true;
                }
                else if (items is manzana)
                {
                    // hp = hp + 100;
                    manzanitas++;
                    return true;
                }
                else
                {
                    itemIndex = -1;
                    return false;
                }

            }
            else
            {
                return false;
            }


        }


        public bool Borra()
        {

            items.RemoveAt(itemIndex);
            itemIndex = -1;
            return true;
        }


        public void añadirP()
        {
            platanitos++;
        }

        public void añadirM()
        {
            manzanitas++;
        }












    }
}
