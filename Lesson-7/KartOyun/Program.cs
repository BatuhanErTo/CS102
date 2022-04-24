using System;

namespace KartOyun // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun();
            oyun.Start();
            oyun.Play();    
            oyun.orderPlayers();
        }
    }
}