using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urunBilgisayar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar1 = new Bilgisayar();
            bilgisayar1.Name = "Laptop";
            bilgisayar1.Price = 250000;
            bilgisayar1.RamAmount = 16;

            bilgisayar1.BilgileriGoster();
            bilgisayar1.RamBilgileriniGoster();
        }
    }

    class Urun
    {

        private string name = "Default ad";
        public string Name {
            get { return name; } 
            set { name = value; } 
        }

        private double price = 0;
        public double Price {
            get { return price; }
            set {  price = value; }
        }

        public

            void BilgileriGoster()
        {
            Console.WriteLine($"Urun Adi: {name}");
            Console.WriteLine($"Urun Fiyati: {price}");
        }

    }

    class Bilgisayar : Urun
    {
        private int ramAmount;
        public int RamAmount
        {
            get { return ramAmount; }
            set { ramAmount = value; }
        }

        public void RamBilgileriniGoster()
        {
            Console.WriteLine($"Ram miktari: {ramAmount}");
        }
    }
}
