using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersUyg
{
    internal class Ogrenci
    {
        public string firstName;
        public string lastName;
        public string number;
        List<Ders> subjects = new List<Ders>();

        public void Add(string dersIsmi, int saat)
        {
            Ders ders = new Ders();
            ders.subject = dersIsmi;    
            ders.hour = saat;   
            subjects.Add(ders);
        }

        public void Not(string dersAdi, double vize, double final)
        {
            int index = subjects.FindIndex(item => item.subject == dersAdi);
            subjects[index].midterm = vize;
            subjects[index].final = final;
        }

        public double ganoHesaplama()
        {
            double gano = 0;
            int st = 0;
            foreach (Ders d in subjects)
            {
                double dersort = d.midterm * 0.4 + d.final * 0.6;
                st += d.hour;
                gano += dersort * d.hour;
            }
            gano = gano / st;
            return gano;
        }
    }
}
