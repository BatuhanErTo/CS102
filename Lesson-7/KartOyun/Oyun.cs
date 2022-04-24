using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartOyun
{
    internal class Oyun
    {
        Deste deste = new Deste();
        Oyuncu[] oyuncu;
        public void Start()
        {
            deste.Olustur();
            deste.Shuffle();
            Console.WriteLine("Enter the how many players is going to play ?");
            int playerSize = Convert.ToInt32(Console.ReadLine());
            oyuncu = new Oyuncu[playerSize];
            for (int i = 0; i < playerSize; i++)
            {
                oyuncu[i] = new Oyuncu();
                Console.WriteLine("{0}. player name : ", i + 1);
                oyuncu[i].name = Console.ReadLine();
                Console.WriteLine("{0}. player surname : ", i + 1);
                oyuncu[i].surname = Console.ReadLine();
            }
        }

        public void Play()
        {
            for (int i = 0; i < oyuncu.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    oyuncu[i].puan += deste.Draw();
                }
            }
            Display();
            orderPlayers();
            displayWinners();
        }

        public void Display()
        {
            Console.WriteLine("========= PLAYERS AND THEIR SCORE =============");
            for (int i = 0; i < oyuncu.Length; i++)
            {
                Console.WriteLine("{0}. player: \nNAME : {1}\tSURNAME : {2}\tSCORE : {3}",i+1,oyuncu[i].name, oyuncu[i].surname, oyuncu[i].puan);
            }
        }

        public void orderPlayers()
        {
            Console.WriteLine("========= WINNERS =============");
            for (int i = 0; i <= oyuncu.Length-2; i++)
            {
               for (int j = 0; j <= oyuncu.Length - 2; j++)
                {
                    if (oyuncu[j].puan < oyuncu[j + 1].puan)
                    {
                        Oyuncu temp = oyuncu[j];
                        oyuncu[j] = oyuncu[j + 1];
                        oyuncu[j + 1] = temp;
                    }
                }
            } 
        }

        public void displayWinners()
        {
            for (int i = 0; i < oyuncu.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("{0}st player is {1} {2}", i + 1, oyuncu[i].name, oyuncu[i].surname);
                        break;
                    case 1:
                        Console.WriteLine("{0}nd player is {1} {2}", i + 1, oyuncu[i].name, oyuncu[i].surname);
                        break;
                    case 2:
                        Console.WriteLine("{0}rd player is {1} {2}", i + 1, oyuncu[i].name, oyuncu[i].surname);
                        break;
                    default:
                        Console.WriteLine("{0}th player is {1} {2}", i + 1, oyuncu[i].name, oyuncu[i].surname);
                        break;
                }
            }
        }
    }
}
