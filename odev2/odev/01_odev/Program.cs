using System.Net.Security;

namespace _01_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    ödev
            //  kullanıcıdan alınan cinsiyet bilgisine göre
            //==> ERKEK ise
            //   yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında ise çalıştığı gün 
            //    sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            //   ==> KADIN ise
            //    yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, yaş 58'ın altında ise çalıştığı gün 
            //    sayısına göre eğer 5600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
            //   ==> cinsiyet bilgisi switch-case ile sorgulanacak
            //   switch case if else

   
            Basla:
            Console.WriteLine("cinsiyetinizi E/K olarak belirtiniz: ");
            char gender = Convert.ToChar(Console.ReadLine().ToUpper());
            switch(gender)
            {
                case 'E':
                    Console.WriteLine("Lütfen kullanıcının yaşını belirtiniz: ");
                    int maleAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kullanıcının maaş tutarını giriniz: ");
                    double wage = Convert.ToDouble(Console.ReadLine());
                    if (maleAge >= 60)
                    {
                        Console.WriteLine("Tebrikler emekli oldunuz. İkramiye tutarınız:" + wage * 10 +" TL");
                    }
                    else
                    {
                        Console.WriteLine("Toplam çalıştığı gün sayısını giriniz: ");
                        int calisilanGun = Convert.ToInt32(Console.ReadLine());
                        if (calisilanGun >= 6000)
                        {
                            Console.WriteLine("Tebrikler emekli oldunuz! İkramiye tutarınız:" + wage * 11 + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Maalesef yaşınız ve çalıştığınız gün sayısı emekli olmanız için yeterli değil.");
                        }

                    }
                break;

                case 'K':
                    Console.WriteLine("Lütfen kullanıcının yaşını belirtiniz: ");
                    int femaleAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Alınan maaş tutarını belirtiniz: ");
                    double femaleWage = Convert.ToDouble(Console.ReadLine());
                    if (femaleAge >= 58)
                    {
                        Console.WriteLine("Tebrikler emekli oldunuz. İkramiye tutarınız:" + femaleWage * 10 + " TL");
                    }
                    else
                    {
                        Console.WriteLine("Toplam çalıştığı gün sayısı:");
                        int calisilanGun = Convert.ToInt32(Console.ReadLine());
                        if (calisilanGun >= 5600)
                        {
                            Console.WriteLine("Tebrikler emekli oldunuz. İkramiye tutarınız:" + femaleWage * 11 + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Maalesef yaşınız ve çalıştığınız gün sayısı emekli olmanız için yeterli değil.");
                        }

                    }
                    break;
                default:
                    {
                        Console.WriteLine("DİKKAT BU BİR UYARI MESAJIDIR! Geçersiz bir karakter girdiniz. Lütfen cinsiyeti erkek ise klavyeden E tuşunu, kadın ise klavyeden lütfen K tuşunu tuşlayınız.");
                        Console.WriteLine("\n");
                    }
                    break;
            }
            goto Basla;
            
        }
    }
}

