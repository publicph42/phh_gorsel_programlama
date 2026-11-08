class Program()
{
    static void Main()
    {
        Odeme odeme1 = new KrediKarti() { Tutar = 12000, taksitSayisi = 3 };
        Odeme odeme2 = new Havale() { Tutar = 10000, IndirimOrani = 40 };
        Odeme odeme3 = new MobilOdeme() { Tutar = 142040 };

        List<Odeme> odemeler = new List<Odeme>();
        odemeler.Add(odeme1);
        odemeler.Add(odeme2);
        odemeler.Add(odeme3);
        foreach (Odeme odeme in odemeler)
        {
            odeme.Ode();
        }
    }
}

class Odeme()
{
    static void main() { }

    public double Tutar { get; set; }

    public virtual void Ode()
    {
        Console.WriteLine("Odeme yapiliyor...");
    }
}

class KrediKarti : Odeme
{
    public int taksitSayisi { get; set; }

    public override void Ode()
    {
        double TaksitTutari = Tutar / taksitSayisi;
        Console.WriteLine($"Toplam tutar: {Tutar}");
        Console.WriteLine($"Taksit sayisi: {taksitSayisi}");
        Console.WriteLine($"Bir taksit tutari: {TaksitTutari}");
    }
}

class Havale : Odeme
{
    public double IndirimOrani { get; set; }

    public override void Ode()
    {
        double indirim = Tutar * IndirimOrani / 100;
        double odenecekTutar = Tutar - indirim;

        Console.WriteLine($"Odenecek tutar: {odenecekTutar}");
    }
}

class MobilOdeme : Odeme { }
