
using System;

public abstract class Tasit  // Tasit sınıfı abstract olacak ki nesne üretilmesin
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public double TabanFiyat { get; set; }
    public abstract double Fiyat { get; }  // Fiyat, her türeyen sınıf için farklı hesaplanacak
}

public class Araba : Tasit
{
    public string YakitTuru { get; set; }  // Dizel, Benzin, Elektrikli vs.
    public string VitesTuru { get; set; }  // Manuel, Otomatik vs.

    public override double Fiyat
    {
        get
        {
            double fiyat = TabanFiyat;

            // Yakıt türüne göre fiyat eklemesi
            if (YakitTuru == "Dizel")
            {
                fiyat += 5000;
            }

            // Vites türüne göre fiyat eklemesi
            if (VitesTuru == "Otomatik")
            {
                fiyat += 10000;
            }

            return fiyat;
        }
    }
}

public class Ucak : Tasit
{
    public int Kapasite { get; set; }  // Uçağın yolcu kapasitesi

    public override double Fiyat
    {
        get
        {
            return TabanFiyat + Kapasite * 100;  // Kapasite başına 100 eklenir
        }
    }
}

public class Tren : Tasit
{
    public int VagonSayisi { get; set; }
    public string Sinif { get; set; }  // A veya B

    public override double Fiyat
    {
        get
        {
            double fiyat = TabanFiyat;

            // Sınıf bilgisine göre fiyat eklemesi
            if (Sinif == "A")
            {
                fiyat += 50000;
            }
            else if (Sinif == "B")
            {
                fiyat += 10000;
            }

            // Vagon sayısına göre fiyat eklemesi
            fiyat += VagonSayisi * 30000;

            return fiyat;
        }
    }
}

public class Gemi : Tasit
{
    public int KamaraSayisi { get; set; }  // Gemideki kamaraların sayısı

    public override double Fiyat
    {
        get
        {
            return TabanFiyat + KamaraSayisi * 40000;  // Kamara başına 40000 eklenir
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Araba nesnesi
        Araba araba = new Araba
        {
            Marka = "Toyota",
            Model = "Corolla",
            TabanFiyat = 150000,
            YakitTuru = "Dizel",
            VitesTuru = "Otomatik"
        };
        Console.WriteLine($"Araba Fiyatı: {araba.Fiyat}");

        // Uçak nesnesi
        Ucak ucak = new Ucak
        {
            Marka = "Boeing",
            Model = "737",
            TabanFiyat = 50000000,
            Kapasite = 200
        };
        Console.WriteLine($"Uçak Fiyatı: {ucak.Fiyat}");

        // Tren nesnesi
        Tren tren = new Tren
        {
            Marka = "Siemens",
            Model = "Velaro",
            TabanFiyat = 20000000,
            VagonSayisi = 10,
            Sinif = "A"
        };
        Console.WriteLine($"Tren Fiyatı: {tren.Fiyat}");

        // Gemi nesnesi
        Gemi gemi = new Gemi
        {
            Marka = "Carnival",
            Model = "Vista",
            TabanFiyat = 80000000,
            KamaraSayisi = 500
        };
        Console.WriteLine($"Gemi Fiyatı: {gemi.Fiyat}");
    }
}