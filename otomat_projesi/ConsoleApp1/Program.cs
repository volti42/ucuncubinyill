using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numb = 5;
            string[] urunler = new string[numb];

            urunler[0] = "ikram";
            urunler[1] = "kola";
            urunler[2] = "yedigün";
            urunler[3] = "laviva";
            urunler[4] = "kraker";

            int[] fiyat = new int[numb];

            fiyat[0] = 20;
            fiyat[1] = 40;
            fiyat[2] = 40;
            fiyat[3] = 25;
            fiyat[4] = 15;
            #region
            //Console.WriteLine("Admin girişi için 9'u tuşlayınız");
            //int adminDogrulama = Convert.ToInt32(Console.ReadLine());

            //if (adminDogrulama == 9)
            //{
            //    Console.WriteLine();
            //}


            #endregion
            int secim = 0;
            int bakiye = 0;
            int secim2;
            while (true)
            {
            Basla:
                Console.WriteLine("Ali Babanın çiftliğindeki otomata hoşgeldiniz! ");
                Console.WriteLine();
                Console.WriteLine(" ÜRÜN LİSTESİ ");
                Console.WriteLine();

                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. " + urunler[i] + " = " + fiyat[i] + " TL");
                }

                Console.WriteLine();
                Console.WriteLine("Lütfen istediğiniz ürünü tuşlayınız. Otomattan çıkış yapmak için 0'ı tuşlayınız.");
                Thread.Sleep(2000);
                Console.WriteLine("Admin paneline erişmek için 9'u tuşlayınız");
                secim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                #region Otomattan çıkış yapma
                if (secim == 0)
                {
                    
                    Console.WriteLine("Otomattan çıkış yapılıyor, iyi günler!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                #endregion

                #region admin paneli
                if (secim == 9)
                {
                    int remaining = 3; // parola hakkı
                    int sayac; //Parola 3 defa yanlış girildiğinde ekrana panelin kaç saniye sonra açılacağını göstermek için


                    while (true)
                    {
                        string administration;
                        int passkey;
                        Console.Write("Admin: ");
                        administration = Console.ReadLine().ToLower();

                        if (administration == "administor")
                        {
                            while (true)
                            {
                                do
                                {

                                    Console.Write("Parola: ");
                                    passkey = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    if (passkey == 541)
                                    {
                                        Console.WriteLine("Giriş Başarılı");
                                        Thread.Sleep(500);
                                        Console.Clear();

                                       
                                        
                                            string[] panel = { "Ürün Ekle", "Fiyat Güncelle", "Ürün Sil", "Ana Menü" };
                                            Console.WriteLine("PANEL İŞLEMLERİ");
                                            Console.WriteLine();

                                            for (int i = 0; i < panel.Length; i++)
                                            {
                                                Console.WriteLine($" {i + 1}. " + panel[i]);
                                            }

                                            int adminSecim = int.Parse(Console.ReadLine());
                                            if (adminSecim == 1)
                                            {
                                                Console.Clear();
                                                Console.Write("Yeni ürün ismi giriniz: ");
                                                string yeniUrun = Console.ReadLine().ToLower();
                                                Array.Resize(ref urunler, urunler.Length + 1);
                                                urunler[urunler.Length - 1] = yeniUrun;
                                                Console.Clear();
                                                Console.Write(yeniUrun + " fiyatını giriniz: ");
                                                int yeniFiyat = int.Parse(Console.ReadLine());
                                                Console.Clear();
                                                Array.Resize(ref fiyat, fiyat.Length + 1);
                                                fiyat[fiyat.Length - 1] = yeniFiyat;
                                                Console.Clear();
                                                Console.WriteLine("Otomat ürün listesi güncellendi.");
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                                Console.WriteLine("___________GÜNCEL ÜRÜN LİSTESİ VE FİYATLARI___________");

                                                for (int i = 0; i < urunler.Length; i++)
                                                {
                                                    Console.WriteLine($"{i + 1}. " + urunler[i] + " = " + fiyat[i] + " TL");
                                                }
                                                Thread.Sleep(3500);
                                                Console.Clear();
                                            }

                                            else if (adminSecim == 2)
                                            {
                                                Console.Clear();
                                                for (int i = 0; i < urunler.Length; i++)
                                                {
                                                    Console.WriteLine($"{i + 1}. " + urunler[i] + " = " + fiyat[i] + " TL");
                                                }

                                                Console.Write("Fiyatı güncellencek ürünü seçiniz = ");
                                                int fiyatSecim = int.Parse(Console.ReadLine());
                                                Console.Clear();
                                                if (fiyatSecim >= 1 && fiyatSecim <= urunler.Length)
                                                {
                                                    int urunSayisi = fiyatSecim - 1;
                                                    string urun = urunler[urunSayisi].ToUpper();

                                                    Console.Write($"{urun} için yeni fiyat giriniz");
                                                    int yeniFiyat = int.Parse(Console.ReadLine());


                                                    fiyat[fiyatSecim - 1] = yeniFiyat;

                                                    Console.WriteLine("Fiyat güncellendi!");
                                                    Thread.Sleep(500);
                                                    Console.Clear();
                                                    Console.WriteLine("___________GÜNCEL ÜRÜN LİSTESİ VE FİYATLARI___________");
                                                    for (int i = 0; i < urunler.Length; i++)
                                                    {
                                                        Console.WriteLine($"{i + 1}. " + urunler[i] + " = " + fiyat[i] + " TL");
                                                    }
                                                    Thread.Sleep(3500);
                                                    Console.Clear();

                                                }
                                            }
                                            else if (adminSecim == 3)
                                            {
                                                Console.Clear();
                                                for (int i = 0; i < urunler.Length; i++)
                                                {
                                                    Console.WriteLine($"{i + 1}. " + urunler[i] + " = " + fiyat[i] + " TL");
                                                }

                                                Console.WriteLine("Silinecek ürünü seçiniz: ");
                                                int silmeSecim = int.Parse(Console.ReadLine());
                                                Console.Clear();
                                                if (silmeSecim >= 1 || silmeSecim < urunler.Length)
                                                {
                                                    for (int i = silmeSecim; i < urunler.Length - 1; i++)
                                                    {
                                                        urunler[i] = urunler[i + 1];
                                                        fiyat[i] = fiyat[i + 1];
                                                    }
                                                    Array.Resize(ref urunler, urunler.Length - 1);
                                                    Array.Resize(ref fiyat, fiyat.Length - 1);
                                                    Console.WriteLine("Ürün silindi");
                                                    Thread.Sleep(500);
                                                    Console.Clear();
                                                    Console.WriteLine("___________GÜNCEL ÜRÜN LİSTESİ VE FİYATLARI___________");
                                                    for (int i = 0; i < urunler.Length; i++)
                                                    {
                                                        Console.WriteLine($"{i + 1}. " + urunler[i] + " = " + fiyat[i] + "");
                                                    }
                                                    Thread.Sleep(3500);
                                                    Console.Clear();
                                                }
                                            }
                                            else if (adminSecim == 4)
                                            {
                                                goto Basla;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı tuşlama.");
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }
                                        

                                    }


                                    else
                                    {
                                        Console.WriteLine("Parola girişi hatalı. Tekrar deneyiniz. Kalan hak: " + (remaining - 1));
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        remaining--;
                                    }

                                }

                                while (remaining > 0);
                                {
                                    if (remaining == 0)
                                    {
                                        sayac = 10;
                                        Console.WriteLine("Parola yanlış girildi. 10 saniye sonra tekar deneyiniz");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        while (true)
                                        {
                                            Console.WriteLine("Parola paneli girişinin açılmasına: " + sayac);
                                            Thread.Sleep(1000);
                                            sayac--;
                                            Console.Clear();
                                            if (sayac == 0)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                                
                            }
                        }

                        else
                        {
                            Console.WriteLine("Admin girişi hatalı. Tekrar deneyiniz.");
                            Thread.Sleep(1000);
                            Console.Clear();

                        }
                    }

                    #endregion

                }
                if (secim > 1 || secim < urunler.Length)
                {
                    Console.Clear();
                    Console.WriteLine("başarılı. Lütfen parayı yatırınız...");
                    bakiye = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bakiye tutarı kontrol ediliyor...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    while (true)
                    {

                        // Bakiyenin yetersiz durumunda para ekleme ve iade bölümü
                        if (bakiye < fiyat[secim - 1])
                        {
                            Console.WriteLine("Bakiyeniz yetersiz.");
                            Console.WriteLine("Para eklemek için 1'e, iade işlemleri için 2'yi tuşlayınız");
                            secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (secim2 == 1 || secim2 == 2)
                            {
                                if (secim2 == 1)
                                {
                                    #region Para ekleme
                                    Console.WriteLine("Para ekleyiniz:");
                                    bakiye += Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("Bakiye tutarı kontrol ediliyor...");
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                    if (bakiye >= fiyat[secim - 1])
                                    {
                                        string alınanUrun = urunler[secim - 1].ToUpper();
                                        Console.WriteLine("Ödeme başarılı, ürün veriliyor. Afiyet olsun.\nFiş ve Para üstü için bekleyiniz...");
                                        Thread.Sleep(3500);
                                        Console.Clear();
                                        Console.WriteLine("Para üstünüz: " + (bakiye - fiyat[secim - 1]) + " TL");
                                        Thread.Sleep(3500);
                                        Console.Clear();
                                        Console.WriteLine("Ali Baba Otomatı Alış-Veriş Fişi");
                                        Console.WriteLine("********************************");
                                        Console.WriteLine("Alınan ürün: " + alınanUrun + "\n");
                                        Console.WriteLine("Toplam yatırılan tutar: " + bakiye + " TL\n");
                                        Console.WriteLine("Müşteriye iade edilen tutar: " + (bakiye - fiyat[secim - 1]) + " TL" + "\n");
                                        Console.WriteLine("İYİ GÜNLER. YİNE BEKLERİZ.");
                                        Thread.Sleep(5000);
                                        Console.Clear();
                                        break;

                                    }
                                    else
                                    {
                                        int gerekenTutar = fiyat[secim - 1] - bakiye;
                                        Console.WriteLine("Ödediğiniz tutar, ürünü almak için yeterli değil.");
                                        Console.WriteLine("Ürünü almak için gereken tutar:" + gerekenTutar + " TL");
                                    }
                                    #endregion
                                }
                                else
                                {
                                    #region Para iadesi
                                    Console.WriteLine("Paranız iade ediliyor. İyi günler.");
                                    Thread.Sleep(500);
                                    Console.WriteLine("İade edilen tutar: " + bakiye);
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    break;
                                    #endregion
                                }
                            }

                            else
                            {
                                Console.WriteLine("Hatalı tuşlama");
                            }

                        }

                        else
                        {
                            string alınanUrun = urunler[secim - 1].ToUpper();
                            Console.WriteLine("Ödeme başarılı, ürün veriliyor. Afiyet olsun.\nFiş ve Para üstü için bekleyiniz...");
                            Thread.Sleep(3500);
                            Console.Clear();
                            Console.WriteLine("Para üstünüz: " + (bakiye - fiyat[secim - 1]) + " TL");
                            Thread.Sleep(3500);
                            Console.Clear();
                            Console.WriteLine("Ali Baba Otomatı Alış-Veriş Fişi");
                            Console.WriteLine("********************************");
                            Console.WriteLine("Alınan ürün: " + alınanUrun + "\n");
                            Console.WriteLine("Toplam yatırılan tutar: " + bakiye + " TL\n");
                            Console.WriteLine("Müşteriye iade edilen tutar: " + (bakiye - fiyat[secim - 1]) + " TL" + "\n");
                            Console.WriteLine("İYİ GÜNLER. YİNE BEKLERİZ.");
                            Thread.Sleep(5000);
                            Console.Clear();
                            break;

                        }

                    }







                }
            }
        }
    }
}


        
    











//for (int secim = 0; secim < urunler.Length; secim++)
//{
//    Console.WriteLine("Lütfen seçmek istediğiniz ürünü tuşlayınız");
//}
// murat yücedağ ders 8 de öğrendiğimiz kart ile bir kredi kartımız olacak ve seçim ekranına o kredi kartını da ekleyeceğiz. Kartın bakiyesi random bakiye olacak ve bu kartı
// 80 tl ve üzeri alışverişlerde vereceğiz.