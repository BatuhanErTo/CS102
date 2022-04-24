using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelDefteri
{
    internal class TelDefteri
    {
        Kisi[] kisiler = new Kisi[20];
        int eklenenS = 0;

        //erisim seviyesi static/nonstatic donderecegiTip metotAdi(parametreler)
        //{

        //}
        public void kisiEkle(string i, string s, string t)
        {
            kisiler[eklenenS] = new Kisi();
            kisiler[eklenenS].isim = i;
            kisiler[eklenenS].soyisim = s;
            kisiler[eklenenS].telefon = t;
            eklenenS++;
        }

        public void kisiEkle(Kisi k) //overload
        {
            kisiler[eklenenS] = k;
            eklenenS++;
        }
    
        public void kisiSil(Kisi k)
        {
            for (int i = 0; i < eklenenS; i++)
            {
                if (kisiler[i] == k)
                {
                    kisiler[i] = kisiler[eklenenS + 1];
                }
            }
        }

        public void Listele()
        {
            for (int i = 0; i < eklenenS; i++)
                kisiler[i].bilgiYaz();
        }

        public string kisiBul(string i, string s)
        {
            string sonuc = "bulunamadi";
            for (int j = 0; j < eklenenS; j++)
            {
                if ((kisiler[j].isim == i) && (kisiler[j].soyisim == s))
                    sonuc = kisiler[j].telefon;
            }
            return sonuc;

        }

        public void Duzenle()
        {
            string temp;
            for (int i = 0; i < eklenenS; i++)
            {
                if (String.Compare(kisiler[i].isim.ToLower(),kisiler[i+1].isim.ToLower()) > 0)
                {
                    temp = kisiler[i].isim;
                    kisiler[i].isim = kisiler[i + 1].isim;
                    kisiler[i+1].isim = temp;   
                }
            }
        }
    }
}
