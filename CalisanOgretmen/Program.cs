using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanOgretmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen1 = new Ogretmen();
            Idareci idareci1 = new Idareci();
            Memur memur1 = new Memur();

            Console.WriteLine("OGRETMEN");
            ogretmen1.Ad = "Ogret Menoglu";
            ogretmen1.Maas = 5000;
            ogretmen1.MaasiArttir(5000);
            ogretmen1.Brans = "Fizik";
            ogretmen1.BilgileriGoster();

            Console.WriteLine("\nIDARECI");
            idareci1.Ad = "Ahmet Idareci";
            idareci1.Maas = 2000;
            idareci1.Gorev = "Mudur";
            idareci1.BilgileriGoster();

            Console.WriteLine("\nMEMUR");
            memur1.Ad = "Memur Mehmet";
            memur1.Departman = "Muhasebe";
            memur1.BilgileriGoster();

        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public double Maas { get; set; }

        public void MaasiArttir(double artisMiktari)
        {
            Maas += artisMiktari;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Maas);
        }
    }

    class Ogretmen : Calisan
    {
        public string Brans { get; set; }
        public int DersSayisi { get; set; }

        public void DersPrograminiGoster()
        {
            Console.WriteLine($"Haftalik Ders Sayisi: {DersSayisi}");
        }

        public void BilgileriGoster()
        {
            Console.WriteLine(Maas);
            Console.WriteLine(Brans);
            Console.WriteLine(DersSayisi);
        }
    }
    class Idareci : Calisan
    {
        public string Gorev { get; set; }
        public void GorevGoster()
        {
            Console.WriteLine(Gorev);
        }

        public void BilgileriGoster()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Maas);
            Console.WriteLine(Gorev);
        }
    }

    class Memur : Calisan
    {
        public string Departman { get; set; }
        public void DepartmanGoster()
        {
            Console.WriteLine(Departman);
        }

        public void BilgileriGoster()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Maas);
            Console.WriteLine(Departman);
        }
    }
}
