using System;

namespace DersUyg // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.firstName = "Mikdat";
            ogrenci1.lastName = "Simsek";
            ogrenci1.number = "600";
            ogrenci1.Add("Mat",6);
            ogrenci1.Not("Mat", 40, 91);
            ogrenci1.Add("Fen", 3);
            ogrenci1.Not("Fen", 40, 100);
            ogrenci1.Add("Sos", 6);
            ogrenci1.Not("Sos", 50, 91);
            double not = ogrenci1.ganoHesaplama();
            Console.WriteLine("{0:F2}",not);
        }
    }
}