using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo ky;
            Mayin myn = new Mayin();    
            Arac arc = new Arac();
            int count = 0, score = 0;
            myn.setBorders();
            myn.setMines();
            do
            {              
                ky = Console.ReadKey();
                bool saver = true;
                arc.hareketEt(ky);
                arc.Uret();
                myn.setBorders();
                myn.drawMines();
                if (ky.Key == ConsoleKey.B) 
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if ((arc.X == myn.X[i]) && (arc.Y == myn.Y[i]))
                        {
                            Console.Beep();
                            myn.drawMines(i);
                            myn.addLocation(i);
                            saver = false;
                            score++;
                        }
                    }
                    if (saver)
                    {
                        count++;
                    }
                }
                
            } while (count < 10);
            Console.Clear();
            if (count < 10)
            {
                Console.SetCursorPosition(1, 34);
                Console.WriteLine("Skor:" + score);
            }
            else
            {
                Console.SetCursorPosition(1, 34);
                Console.WriteLine("GAME OVER!!!!");
            }
           // Console.ReadKey();

        }
    }
}
