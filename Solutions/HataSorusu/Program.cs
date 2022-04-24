using System;

namespace HataSorusu // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = Metot(5, 2);
        }

        public static double Metot(int a, double b)
        {
            int sonuc = 0;
            for (int i = 0; i < a; i++)
            {
                sonuc += Convert.ToInt32(b);
            }
            return sonuc;
        }
    }
}
