using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AppLes10Ass1
{
    internal class Randevu
    {
        public static string dosya_yolu = @"C:\Users\batuh\source\repos\CS102\Lesson-10\randevu.txt";
        public static void Ekle(string tc,string ad, string soyad, string pol, string tarih, string saat)
        {
            string randevu = tc + "*" + ad + "*" + soyad + "*" + pol + "*" + tarih + "*" + saat;
            StreamWriter sw = new StreamWriter(dosya_yolu,true);
            sw.WriteLine(randevu);
            sw.Close();
        }

        public static bool VarMi(string pol, string tarih, string saat)
        {
            bool result = false;
            StreamReader rd = new StreamReader(dosya_yolu);
            string satir = "";
            while (rd.EndOfStream == false && result == false)
            {
                satir = rd.ReadLine();
                string[] parcalar = satir.Split('*');
                if (parcalar[3] == pol && parcalar[4] == tarih && parcalar[5] == saat)
                {
                    result = true;
                }
            }
            rd.Close();
            return result;
        }

        public static string Yazdir()
        {
            StreamReader str = new StreamReader(dosya_yolu);
            string result = str.ReadToEnd();
            str.Close();
            return result;
        }

        public static string Search(string klinik, string tarih)
        {
            StreamReader read = new StreamReader(dosya_yolu);
            string result = "";
            while (read.EndOfStream == false)
            {
                string[] satir = read.ReadLine().Split('*');
                if (satir[3] == klinik && satir[4] == tarih)
                {
                    result += satir[0] + " " + satir[1] + " " + satir[2] + " " + satir[5] + Environment.NewLine;
                }
            }
            read.Close();
            return result;
        }

    }
}
