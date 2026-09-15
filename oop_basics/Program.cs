using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace oop_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci yeniOgrenci = new Ogrenci();

            yeniOgrenci.ad = "omer";
            yeniOgrenci.soyad = "oner";
            yeniOgrenci.not = 88;
            yeniOgrenci.ders = "Hayat";

            yeniOgrenci.DersDurum();
        }
    }
}
