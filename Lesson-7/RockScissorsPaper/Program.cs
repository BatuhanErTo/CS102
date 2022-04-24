using System;

namespace RockScissorsPaper // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); 
            game.Play();
        }
    }
}