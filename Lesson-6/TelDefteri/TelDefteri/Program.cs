using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelDefteri
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kisi k1 = new Kisi();
           k1.isim = "Ali";
           k1.soyisim = "Demir";
           k1.telefon="3434";
           k1.bilgiYaz();

            TelDefteri defterim = new TelDefteri();
            /**
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("isim?");
                string ad = Console.ReadLine();
                Console.WriteLine("soyisim?");
                string soyad = Console.ReadLine();
                Console.WriteLine("telefon?");
                string tel = Console.ReadLine();
                defterim.kisiEkle(ad, soyad, tel);

            }
            **/
            defterim.kisiEkle("ahmet", "guneş", "+3434");
            defterim.kisiEkle("ali", "demir", "123-456");
            defterim.kisiEkle("mehmet", "celik", "123#");
            defterim.kisiEkle("ayse", "deniz", "+905");
            defterim.kisiEkle("fatma", "lale", "+3434");
            
            defterim.kisiEkle(k1);
            defterim.Listele();
            defterim.kisiSil(k1);
            defterim.Listele();
            defterim.Duzenle();
            defterim.Listele();

            string s = defterim.kisiBul("hatice", "deniz");
            Console.WriteLine("Telefon:" + s);

            Console.ReadKey();
        }
    }
}
