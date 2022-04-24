using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockScissorsPaper
{
    internal class Game
    {
        Player player = new Player();
        public void Play()
        {
            Console.WriteLine("ROCK : r, SCISSORS : s, PAPER : p");
            // For the computer rock : 1, scissors : 2, paper : 3.
            Random random = new Random();
            int computerScore = 0;
            for (int i = 0; i < 3; i++)
            {
                int computerChoice = random.Next(1,4);
                do
                {
                    Console.Write("\nYour choice :==> ");
                    player.choice = Convert.ToChar(Console.ReadLine().ToLower());
                } while ((player.choice != 'r') && (player.choice != 's') && (player.choice != 'p'));
                if (computerChoice==1)
                    Console.Write("Computer choice :==> ROCK");
                else if (computerChoice == 2)
                    Console.Write("Computer choice :==> SCISSORS");
                else
                    Console.Write("Computer choice :==> PAPER");

                if (Compare(computerChoice, player.choice) == 0)
                {
                    player.score++;
                }
                else if (Compare(computerChoice, player.choice) == 1)
                {
                    computerScore++;
                }
                else
                {
                    i--;
                }
            }
            whoWin(computerScore, player.score);
            
        }
        //if compare return 0, that means player wins. Return 1 means computer wins and rest of it means draw
        public int Compare(int computerChoice, char playerChoice)
        {
            if (computerChoice == 1)
            {
                if (playerChoice == 'p')
                    return 0;
                else if (playerChoice == 's')
                    return 1;
                else
                    return 2;
            }
            else if (computerChoice == 2)
            {
                if (playerChoice == 'r')
                    return 0;
                else if (playerChoice == 'p')
                    return 1;
                else
                    return 2;
            }
            else
            {
                if (playerChoice == 's')
                    return 0;
                else if (playerChoice == 'r')
                    return 1;
                else
                    return 2;
            }
                
        }

        public void whoWin(int s1, int s2)
        {
            if (s1 > s2)
                Console.WriteLine("\nCopmuter win");
            else if (s1 < s2)
                Console.WriteLine("\nYou win");
        }
    }
}
