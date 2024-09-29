namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Basla:
            Console.WriteLine("Vize notunu giriniz:");
            double vize = int.Parse(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz:");
            double final = Convert.ToDouble(Console.ReadLine());
            double ortalama;

            if ((vize >= 0 && vize <= 100) && (final >= 0 && final <= 100))
            {
                vize = vize * 0.40;
                final = final * 0.60;
                ortalama = vize + final;
                if (ortalama < 20)
                {
                    Console.WriteLine("Ortalama harf notunuz ff");
                }
                else if (ortalama >= 21 && ortalama <= 45)
                {
                    Console.WriteLine("Ortalama harf notunuz dd");
                }
                else if (ortalama >= 46 && ortalama <= 60)
                {
                    Console.WriteLine("Ortalama harf notunuz cc");
                }
                else if (ortalama >= 61 && ortalama <= 75)
                {
                    Console.WriteLine("Ortalama harf notunuz bb");
                }
                else if (ortalama >= 76 && ortalama <= 100)
                {
                    Console.WriteLine("Ortalama harf notunuz aa");
                }
            }
            goto Basla;
        }
    }
}
     