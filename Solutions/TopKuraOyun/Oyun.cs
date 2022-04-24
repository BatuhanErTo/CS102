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
        Player player2;
        int[] valuesOfBalls;
        public void Start()
        {
            player1 = new Player();
            player2 = new Player();
            valuesOfBalls = new int[5];
            torba.Olustur();
            torba.Shuffle();
        }

        public void Play()
        {
            playerChoosing();

            computerChoosing();

            Compare();

            Display();
        }

        public void playerChoosing()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("1. Player please enter your {0}. guess : ", i + 1);
                player1.choice[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("2. Player please enter your {0}. guess : ", i + 1);
                player2.choice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void computerChoosing()
        {
            for (int i = 0; i < 5; i++)
            {
                valuesOfBalls[i] = torba.Draw();
            }
        }

        public void Compare()
        {
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
        }

        public void Display()
        {
            Console.WriteLine("==============================");
            Console.Write("Player1 choices  ==> ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(player1.choice[i]+" ");
            }
            Console.Write("\nPlayer2 choices  ==> ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(player2.choice[i]+" ");
            }
            Console.Write("\nComputer choices  ==> ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(valuesOfBalls[i]+" ");
            }
            Console.WriteLine("\n==========================");
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
