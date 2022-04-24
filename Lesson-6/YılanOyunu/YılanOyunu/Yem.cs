using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YılanOyunu
{
    internal class Yem
    {
        public int X, Y;
        public char sekil = '*';
        public void Uret()
        {
            Random random = new Random();
            X = random.Next(1,31);
            Y = random.Next(1,21);
        }
        public void Ciz()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(sekil); 
        }
    }
}
