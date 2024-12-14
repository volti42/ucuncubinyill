namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba
            {
                Marka = "Ford",
                Model = "Focus",
                TabanFiyat = 1500000,
                YakitTuru = "Dizel",
                VitesTuru = "Otomatik"
            };
            Console.WriteLine($"Araba Fiyatı: {araba.Fiyat}");
        }
        public abstract class Tasit
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            public virtual double Fiyat { get; set; }
            public double TabanFiyat { get; set; }
        }
        public class Araba : Tasit
        {
            public string YakitTuru { get; set; }
            public string VitesTuru { get; set; }
            public override double Fiyat
            {
                get
                {
                    double fiyat = TabanFiyat;
                    if (YakitTuru == "Dizel")
                    {
                        fiyat += 5000;
                    }

                    else if (YakitTuru == "Benzin")
                    {
                        fiyat += 10000;
                    }
                    if (VitesTuru == "Otomatik")
                    {
                        fiyat += 10000;
                    }
                    else if (VitesTuru == "Manuel")
                    {
                        fiyat += 5000;
                    }
                    return fiyat;
                }
            }
        }
        public class Ucak : Tasit
        {
            public int Kapasite { get; set; }
            public override double Fiyat
            {
                get
                {
                    return TabanFiyat + Kapasite * 100;
                }
            }
        }
        public class Tren : Tasit
        {
            public int VagonSayisi { get; set; }
            public string SinifBilgisi { get; set; }
            public override double Fiyat
            {
                get
                {
                    double fiyat = TabanFiyat;
                    if (SinifBilgisi == "A")
                    {
                        fiyat += 5000;
                    }
                    else if (SinifBilgisi == "B")
                    {
                        fiyat += 10000;
                    }
                    fiyat += VagonSayisi * 30000;
                    return fiyat;
                }
            }

        }
        public class Gemi : Tasit
        {
            public int Kamara { get; set; }
            public override double Fiyat
            {
                get
                {
                    return TabanFiyat + Kamara * 40000;
                }

            }
        }
    }
}
