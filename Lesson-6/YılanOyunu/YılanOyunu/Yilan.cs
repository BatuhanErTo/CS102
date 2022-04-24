using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YılanOyunu
{
    internal class Yilan
    {

        public char sekil = '>';
        public int X = 1, Y = 1;


        public void Ciz()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write(sekil);
        }

        public void Hareket(ConsoleKeyInfo basilanTus)
        {
            if (basilanTus.Key == ConsoleKey.UpArrow)
                Y--;
            if (basilanTus.Key == ConsoleKey.DownArrow)
                Y++;
            if (basilanTus.Key == ConsoleKey.RightArrow)
                X++;
            if (basilanTus.Key == ConsoleKey.LeftArrow)
                X--;

            if (X == 0)
                X = 30;
            if (X == 31)
                X = 1;
            if (Y == 0)
                Y = 20;
            if (Y == 21)
                Y = 0;
        }

        public bool IsEaten(Yem yem)
        {
            if ((X == yem.X) && (Y == yem.Y))
                return true;
            return false;   
        }

    }
}
