using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineGame
{
    internal class Arac
    {
        public char chr = '>';
        public int X = 2;
        public int Y = 2;

        Mayin myn = new Mayin();
        public void Uret()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write(chr);
        }
        public void hareketEt(ConsoleKeyInfo basilan)
        {
            if (basilan.Key == ConsoleKey.UpArrow)
                Y--;
            if (basilan.Key == ConsoleKey.DownArrow)
                Y++;
            if (basilan.Key == ConsoleKey.LeftArrow)
                X--;
            if (basilan.Key == ConsoleKey.RightArrow)
                X++;

            if (X == 31)
                X = 1;
            if (X == 0)
                X = 30;
            if (Y == 0)
                Y = 30;
            if (Y == 31)
                Y = 1;
        }
    }
}
