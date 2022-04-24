using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelDefteri
{
    internal class Kisi
    {
        //veriler,ozellikler
        //islevler

        //erisim seviyesi static/nonstatic(boş) tipi degiskenAdi;

        //public private protected

        public string isim;
        public string soyisim;
        public string telefon;

        public void bilgiYaz()
        {
            Console.WriteLine("{0} {1}: {2}", isim, soyisim, telefon);
        }
    }
}
