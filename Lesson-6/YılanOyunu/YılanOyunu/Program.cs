using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YılanOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skor = 0;
            Yilan snake = new Yilan();
            Yem yem = new Yem();

            yem.Uret();
            ConsoleKeyInfo basilantus;
            do
            {
                basilantus = Console.ReadKey();
                snake.Hareket(basilantus);
                snake.Ciz();
                yem.Ciz();
                if (snake.IsEaten(yem) == true)
                {
                    skor++;
                    yem.Uret();
                    snake.Ciz();
                }
                Console.SetCursorPosition(1, 23);
                Console.WriteLine("Skor:" + skor);
            } while (basilantus.Key != ConsoleKey.Escape);

            Console.ReadKey();
        }
    }
}
