using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int urunSayisi;
        Console.WriteLine("Urun sayisini giriniz.");
        urunSayisi = Convert.ToInt32(Console.ReadLine());


        double[] urunFiyati = new double[urunSayisi];
        string[] urunAdi = new string[urunSayisi];

        //Console.WriteLine("Urun sayisini giriniz.");
        //urunSayisi = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < urunSayisi; i++)
        {

            Console.WriteLine("Urun adini giriniz.");
            urunAdi[i] = Console.ReadLine();

            Console.WriteLine("Urun fiyatini giriniz.");
            urunFiyati[i] = Convert.ToInt32(Console.ReadLine());
        }

        //double toplam = 0;
        for (int i = 0; i < urunSayisi; i++)
        {
            Console.WriteLine(urunAdi[i] + ": " + urunFiyati[i] + " TL");
            //toplam += urunFiyati;
            //toplam += urunFiyati[i];
            //Console.WriteLine("Toplam ürün fiyatı:" + toplam + " TL");
        }

        double toplam = 0;

        for (int i = 0; i < urunSayisi; i += 1)
        {
            toplam += urunFiyati[i];
            //Console.WriteLine("Toplam urun fiyati: " + toplam + " TL");
        }
        Console.WriteLine("Toplam urun fiyati: " + toplam + " TL");
        //toplam += urunFiyati[];
        //Console.WriteLine("Toplam urun fiyati: " + toplam + " TL");



    }
}