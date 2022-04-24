using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool d1 = true;
            Console.WriteLine("Bool: " + sizeof(bool));

            char d2 = '\0';// 65;
            Console.WriteLine("char: " + sizeof(char));

            byte d3 = 255;
            Console.WriteLine("byte: " + sizeof(byte));
            Console.WriteLine("Min Value: {0}, Max:{1}",byte.MinValue,byte.MaxValue);

            sbyte d4 = -128;
            Console.WriteLine("sbyte: " + sizeof(sbyte));
            Console.WriteLine("Min Value: {0}, Max:{1}", sbyte.MinValue, sbyte.MaxValue);

            d4 = (sbyte)d3;
            Console.WriteLine("d4:" + d4);

            short d5 = 5;
            Console.WriteLine("short: " + sizeof(short));
            Console.WriteLine("Min Value: {0}, Max:{1}", short.MinValue, short.MaxValue);

            ushort d6 = 0;
            Console.WriteLine("ushort: " + sizeof(ushort));
            Console.WriteLine("Min Value: {0}, Max:{1}", ushort.MinValue, ushort.MaxValue);

            int d7 = 7;
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("Min Value: {0}, Max:{1}", int.MinValue, int.MaxValue);

            uint d8 = 7;
            Console.WriteLine("uint: " + sizeof(uint));
            Console.WriteLine("Min Value: {0}, Max:{1}", uint.MinValue, uint.MaxValue);

            long d9 = 9223372036854775807L;
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("Min Value: {0}, Max:{1}", long.MinValue, long.MaxValue);

            d9 = d7; //implicit dönüşüm
            d7 = (int)d9;//explicit dönüşüm


            ulong d10 = 0;
            Console.WriteLine("ulong: " + sizeof(ulong));
            Console.WriteLine("Min Value: {0}, Max:{1}", ulong.MinValue, ulong.MaxValue);

            decimal d11 = 79228162514264337593543950335M;
            Console.WriteLine("decimal: " + sizeof(decimal));
            Console.WriteLine("Min Value: {0}, Max:{1}", decimal.MinValue, decimal.MaxValue);

            float d12 = 3.12f;
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("Min Value: {0}, Max:{1}", float.MinValue, float.MaxValue);

            d7 = (int)d12;
            Console.WriteLine("d7:" + d7);
           // d12 = d7;//implicit

            double d13 = 1.2;
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("Min Value: {0}, Max:{1}", double.MinValue, double.MaxValue);

            int d14 = Convert.ToInt32(d13);
            double d15 = double.Parse("3,12");
            Console.WriteLine("d15:" + d15);
            
            

            Console.ReadKey();




        }
    }
}
