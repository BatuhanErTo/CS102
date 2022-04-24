using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartOyun
{
    internal class Deste
    {
        Kart[] kart = new Kart[52];
        public void Olustur()
        {
            string[] turler = new string[4] {"Karo", "Kupa", "Sinek", "Maça"};
            string[] sayisi = new string[13] {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
            int[] puani = new int[13] { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14 };
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    kart[k] = new Kart();
                    kart[k].turu = turler[i];
                    kart[k].sayisi = sayisi[j];
                    kart[k].puani = puani[j];
                    k++;
                }
            }    
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 52; i++)
            {
                int randomNumber = rand.Next(0, 52);
                Kart temp = kart[randomNumber]; 
                kart[randomNumber] = kart[i];
                kart[i] = temp;
            }
        }
        int kS = 0;
        public int Draw()
       {
            return kart[kS++].puani;
       }
    }
}
