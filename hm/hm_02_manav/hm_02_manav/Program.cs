using System.Collections;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList halMeyve = new ArrayList() { "ELMA", "ARMUT", "ÇİLEK", "MUZ", "KİVİ" };
            ArrayList halSebze = new ArrayList() { "DOMATES", "SALATA", "BİBER", "SARIMSAK", "MAYDONOZ" };
            ArrayList manavMeyve = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebze = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();
            #region Hal
            while (true)
            {

                Console.WriteLine("Meyve için 1'e, Sebze için 2'ye basınız. Halden çıkmak için 0'ı tuşlayınız.");
                int secim = int.Parse(Console.ReadLine());
                Console.Clear();
                #region Meyve
                if (secim == 1)
                {
                    while (true)
                    {
                        int i = 0;
                        foreach (string meyve in halMeyve)
                        {
                            Console.WriteLine($"{i + 1}.  {meyve}");
                            i++;
                        }
                        Console.WriteLine("Almak istediğiniz ürünü yazın.(1-5)");
                        int secilenMeyve = int.Parse(Console.ReadLine());
                        string secilenMeyveAdi = (string)halMeyve[secilenMeyve - 1];
                        if (manavMeyve.Contains(secilenMeyveAdi))
                        {
                            int meyveIndex = manavMeyve.IndexOf(secilenMeyveAdi);
                            int mevcutKilo = (int)manavMeyveKilo[meyveIndex];

                            Console.Write("Kaç kilo eklemek istersiniz: ");
                            int kilo = int.Parse(Console.ReadLine());
                            manavMeyveKilo[meyveIndex] = mevcutKilo + kilo; // Kilo ekleniyor
                        }
                        else
                        {
                            manavMeyve.Add(secilenMeyveAdi); // Yeni meyve ekleniyor
                            Console.Write("Kaç kilo: ");
                            int kilo = int.Parse(Console.ReadLine());
                            manavMeyveKilo.Add(kilo);
                        }

                        Console.WriteLine("Başka meyve eklemek ister misiniz?(E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (cevap == "H")
                        {
                            Console.Clear();
                            break;
                        }
                        else { Console.WriteLine("Hatalı Tuşlama"); Thread.Sleep(500); Console.Clear(); }

                    }
                    // Manavda şu anki meyve ve kiloları göster
                    Console.WriteLine("Manavda şu anki Meyve ve Kilolar:");
                    for (int j = 0; j < manavMeyve.Count; j++)
                    {
                        Console.WriteLine($"{manavMeyve[j]}: {manavMeyveKilo[j]} kg");
                    }
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                #endregion
                #region Sebze
                else if (secim == 2)
                {
                    while (true)
                    {
                        int i = 0;
                        foreach (var sebze in halSebze)
                        {
                            Console.WriteLine($"{i + 1}. {sebze}");
                            i++;
                        }
                        Console.WriteLine("Almak istediğiniz ürünü yazın. (1-5)");
                        int secilenSebze = int.Parse(Console.ReadLine());
                        string secilenSebzeAdi = (string)halSebze[secilenSebze - 1];
                        if (manavSebze.Contains(secilenSebzeAdi))
                        {
                            int sebzeIndex = manavSebze.IndexOf(secilenSebzeAdi);
                            int mevcutKilo = (int)manavSebzeKilo[sebzeIndex];

                            Console.Write("Kaç kilo eklemek istersiniz: ");
                            int kilo = int.Parse(Console.ReadLine());
                            manavSebzeKilo[sebzeIndex] = mevcutKilo + kilo; // Kilo ekleniyor
                        }
                        else
                        {
                            manavSebze.Add(secilenSebzeAdi); // Yeni meyve ekleniyor
                            Console.Write("Kaç kilo: ");
                            int kilo = int.Parse(Console.ReadLine());
                            manavSebzeKilo.Add(kilo);
                        }
                        Console.WriteLine("Başka sebze eklemek ister misiniz? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap == "E")
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (cevap == "H")
                        {
                            Console.Clear();
                            break;
                        }
                        else { Console.WriteLine("Hatalı tuşlama"); Thread.Sleep(500); Console.Clear(); }
                    }
                    Console.WriteLine("Manavdaki şu an sebze ve kilolar:");
                    for (int j = 0; j < manavSebze.Count; j++)
                    {
                        Console.WriteLine($"{manavSebze[j]}: {manavSebzeKilo[j]} kg");
                    }
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                #endregion
                #region çıkış
                else if (secim == 0)
                {
                    Console.WriteLine("Manavdaki Meyveler:");
                    for (int j = 0; j < manavMeyve.Count; j++)
                    {
                        Console.WriteLine($"{manavMeyve[j]}: {manavMeyveKilo[j]} kg");
                    }
                    Thread.Sleep(2500);
                    Console.Clear();
                    Console.WriteLine("Manavdaki Sebzeler:");
                    for (int j = 0; j < manavSebze.Count; j++)
                    {
                        Console.WriteLine($"{manavSebze[j]}: {manavSebzeKilo[j]} kg");
                    }
                    Thread.Sleep(2500);
                    Console.Clear();

                    break;
                }
                else { Console.WriteLine("Hatalı tuşlama"); Thread.Sleep(500); Console.Clear(); }
                #endregion
            }
            #endregion
            #region Manav
            //manav
            while (true)
            {
                Console.WriteLine("Meyve için 1'e, Sebze için 2'ye basınız. Manavdan çıkmak için 0'ı tuşlayınız.");
                int cevap = int.Parse(Console.ReadLine());
                Console.Clear();
                if (cevap == 1)
                {
                    for (int i = 0; i < manavMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {manavMeyve[i]}: {manavMeyveKilo[i]} kg");
                    }

                    Console.WriteLine("Almak istediğiniz ürünün numarasını yazınız.");
                    int alınacakUrun = int.Parse(Console.ReadLine()) - 1;
                    if (alınacakUrun >= 0 && alınacakUrun < manavMeyve.Count)
                    {
                        Console.WriteLine($"{manavMeyve[alınacakUrun]} almak istiyorsunuz.");
                        Console.Write("Kaç kilo: ");

                        int kilo = int.Parse(Console.ReadLine());
                        Thread.Sleep(500);
                        Console.Clear();

                        int mevcutKilo = (int)manavMeyveKilo[alınacakUrun];
                        if (mevcutKilo >= kilo)
                        {

                            manavMeyveKilo[alınacakUrun] = mevcutKilo - kilo;
                            musteri.Add($"{manavMeyve[alınacakUrun]}: {kilo} kg");
                            Console.WriteLine($"{kilo} kg {manavMeyve[alınacakUrun]} alındı. Kalan {manavMeyveKilo[alınacakUrun]} kg");
                            Thread.Sleep(2500);
                            Console.Clear();
                        }
                        else { Console.WriteLine("Yeterli stok yok"); Thread.Sleep(500); Console.Clear(); }


                    }
                }
                else if (cevap == 2)
                {
                    for (int i = 0; i < manavSebze.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {manavSebze[i]} - {manavSebzeKilo[i]} kg");
                    }
                    Console.WriteLine("Almak istediğiniz ürünün numarasını yazınız.");
                    int alınacakUrun = int.Parse(Console.ReadLine()) - 1;
                    if (alınacakUrun >= 0 && alınacakUrun < manavSebze.Count)
                    {
                        Console.WriteLine($"{manavSebze[alınacakUrun]} almak istiyorsunuz.");
                        Console.Write("Kaç kilo: ");
                        int kilo = int.Parse(Console.ReadLine());
                        Thread.Sleep(500);
                        Console.Clear();
                        int mevcutKilo = (int)manavSebzeKilo[alınacakUrun];
                        if (mevcutKilo >= kilo)
                        {
                            manavSebzeKilo[alınacakUrun] = mevcutKilo - kilo;
                            musteri.Add($"{manavSebze[alınacakUrun]}: {kilo} kg");
                            Console.WriteLine($"{kilo} kg {manavSebze[alınacakUrun]} alındı. Kalan {manavSebzeKilo[alınacakUrun]} kg");
                            Thread.Sleep(2500);
                            Console.Clear();
                        }
                        else { Console.WriteLine("Yeterli stok yok"); Thread.Sleep(500); Console.Clear(); }

                    }
                    else { Console.WriteLine("Hatalı tuşlama"); Thread.Sleep(500); Console.Clear(); }

                }
                else if (cevap == 0)
                {
                    Console.WriteLine("Yaptığınız alışverişler:");
                    foreach (var item in musteri)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }
                #endregion
            }
        }
    }
}