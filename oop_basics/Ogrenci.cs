using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_basics
{
    internal class Ogrenci
    {
        public string ad;
        public string soyad;
        public int not;
        public string ders;

        public void DersDurum()
        {
            if (not < 60)
            {
                Console.WriteLine($"Ogrenci: {ad} {soyad}, {not} ile {ders} dersinden kalmistir!");
            }
            else
            {
                Console.WriteLine($"Ogrenci: {ad} {soyad}, {not} ile {ders} dersinden gecmistir!");
            }
        }
    }
}
