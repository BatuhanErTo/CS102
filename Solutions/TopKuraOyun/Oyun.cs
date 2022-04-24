using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKuraOyun
{
    internal class Oyun
    {
        Torba torba = new Torba();
        Player player1;
        Player player2; // ?????????
        public void Start()
        {
            player1 = new Player();
            player2 = new Player();
            torba.Olustur();
            torba.Shuffle();
        }

        public void Play()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("1. Player please enter your {0} guess : ", i + 1);
                player1.choice[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("2. Player please enter your {0} guess : ", i + 1);
                player2.choice[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] valuesOfBalls = new int[5];
            for (int i = 0; i < 5; i++)
            {
                valuesOfBalls[i] = torba.Draw();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (player1.choice[j] == valuesOfBalls[i])
                    {
                        player1.score++;
                    }

                    if (player2.choice[j] == valuesOfBalls[i])
                    {
                        player2.score++;
                    }
                }
            }

            if (player1.score > player2.score)
            {
                Console.WriteLine("Player1 win");
            }
            else if (player1.score < player2.score)
            {
                Console.WriteLine("Player2 win");
            }
            else
            {
                Console.WriteLine("Drawn");
            }


        }
    }
}
