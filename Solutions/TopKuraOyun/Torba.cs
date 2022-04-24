using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKuraOyun
{
    internal class Torba
    {
        Top[] top = new Top[50];

        public void Olustur()
        {
            int[] degerler = new int[10] {0,1,2,3,4,5,6,7,8,9};
            int i = 0;
            while (i < 50)
            {
                for (int j = 0; j < 5; j++)
                {
                    top[i] = new Top();
                    top[i].turu = degerler[j];
                    i++;
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            { 
                for (int j = 0; j < 5; j++)
                {
                    int x = rand.Next(0, 50);
                    Top temp = top[i];
                    top[i] = top[j];
                    top[j] = temp;
                }
            }
        }

        int kx = 0;
        public int Draw()
        {
            return top[kx++].turu;
        }
    }
}
