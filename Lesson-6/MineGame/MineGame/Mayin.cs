using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineGame
{
    internal class Mayin
    {
        public int[] X = new int[5];
        public int[] Y = new int[5];
        public char chr1 = '*';
        public char chr2 = 'O';
        //public int location;
        public int[] lct = new int[5];
        public int size = 0;
        public void setBorders()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('.');
            }
            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('.');

            }
            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(i, 29);
                Console.Write('.');
            }
            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(29, i);
                Console.Write('.');
            }
        }

        public void setMines()
        {

            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                X[i] = rand.Next(2,29);
                Y[i] = rand.Next(2,29);
            }
        }

        public void addLocation(int location)
        {
            lct[size] = location;
            size++;
        }
        public void drawMines()
        {
            bool a;
            for (int i = 0; i < 5; i++)
            {
                a = true;
                for (int j = 0; j < size; j++)
                {
                    if (i == lct[j])
                    {
                        a = false;
                        Console.SetCursorPosition(X[i], Y[i]);
                        Console.Write(chr2);
                        break;
                    }
                }
                if (a)
                {
                    Console.SetCursorPosition(X[i], Y[i]);
                    Console.Write(chr1);
                }
            }
        }
        public void drawMines(int lc)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(X[i], Y[i]);
                Console.Write(chr1);
            }
            Console.SetCursorPosition(X[lc], Y[lc]);
            Console.Write(chr2);
        }
    }
}
