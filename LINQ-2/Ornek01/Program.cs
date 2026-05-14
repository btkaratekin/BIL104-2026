using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek01
{
    internal class Program
    {
        static List<Kitap> Kitaplar = KitapListe.ListeyiGetir();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("LINQ İşlemleri OrderBy(),OrderByDescending(), ThenBy() ve ThenByDescending() Metodları Kullanımı");
                Console.WriteLine("\n\nMenü");
                Console.WriteLine("1. Tüm Kitapları Yazar Adlarına Göre Sırala");
                Console.WriteLine("2. Seçilen Bir Kategoriye Göre Kitapları Sayfa Sayısına Göre Azalan Sırala");
                Console.WriteLine("3. 1990 ile 2020 Arasında Basılan Kitapları Fiyatlarına Göre Sırala");
                Console.WriteLine("4. YayınEvine Göre Sıralama Seçimi Sonrası Sayfa Sayısına Göre Sırala");
                Console.WriteLine("5. Seçilen Bir Yazarın Kitaplarını Basım Yıllarına Göre (Azalan) Sırala");
                Console.WriteLine("6. Çıkış");
                Console.Write("\nSeçiminiz....:");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        {
                            YazarAdinaGoreSirala();
                            break;
                        }
                    case 2:
                        {
                            KategoriyeGoreSirala();
                            break;
                        }
                    case 3:
                        {
                            BasimYillarinaGoreSirala();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("YayınEvlerine Göre Sıralama Seçenekleri\n");
                            Console.WriteLine("1. A dan Z ye Göre");
                            Console.WriteLine("2. Z den A ya Göre");

                            Console.Write("\nSeçiminiz...:");
                            int selection = int.Parse(Console.ReadLine());
                            if (selection == 1)
                            {
                                YayinEvlerineGoreSirala(true);
                            }
                            else
                            {
                                YayinEvlerineGoreSirala(false);
                            }

                            break;
                        }
                    case 5:
                        {
                            YazaraGoreSirala();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Çıkış yapılıyor...");
                            Thread.Sleep(2000);
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Geçersiz Seçim...Tekrar Deneyin...");
                            Thread.Sleep(2000);
                            break;
                        }

                }
            }

        }

        private static void YazaraGoreSirala()
        {
            Console.Clear();
            Console.WriteLine("Yazar Adlarına Göre Sıralama Seçenekleri\n");
            List<string> Yazarlar = Kitaplar.Select(k => k.Yazar).Distinct().OrderBy(x=>x).ToList();
            int sayac = 1;
            foreach (string yazar in Yazarlar)
            {
                Console.WriteLine(sayac + " - " + yazar);
                sayac++;
            }
            Console.Write("\nSeçiminiz....:");
            int secim = int.Parse(Console.ReadLine());
            string secilenyazar = Yazarlar[secim - 1];
            List<Kitap> SiraliKitaplar = Kitaplar.Where(k => k.Yazar == secilenyazar).OrderByDescending(k => k.BasimYili).ToList();
            Console.WriteLine();
            foreach (Kitap ktp in SiraliKitaplar)
            {
                Console.WriteLine($"{ktp.Adi,-35} {ktp.Yazar,-30}  {ktp.YayinEvi,-30}   {ktp.Kategori,-20}  {ktp.SayfaSayisi,5}\t{ktp.BasimYili,5}     {ktp.Fiyat,8:C}");
            }
            Console.WriteLine("\nListedeki Kitap Sayısı...: " + SiraliKitaplar.Count);
            Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void YayinEvlerineGoreSirala(bool artan)
        {
            Console.Clear();
            Console.WriteLine("YayınEvlerine Göre Sıralanmış Kitaplar Listesi");
            List<Kitap> SiraliKitaplar = artan == true ? Kitaplar.OrderBy(k => k.YayinEvi).ThenBy(k => k.SayfaSayisi).ToList() 
                                              : Kitaplar.OrderByDescending(k => k.YayinEvi).ThenBy(k => k.SayfaSayisi).ToList();
            foreach (Kitap ktp in SiraliKitaplar)
            {
                Console.WriteLine($"{ktp.Adi,-35} {ktp.Yazar,-30}  {ktp.YayinEvi,-30}   {ktp.Kategori,-20}  {ktp.SayfaSayisi,5}\t{ktp.BasimYili,5}     {ktp.Fiyat,8:C}");
            }
            Console.WriteLine("\nListedeki Kitap Sayısı...: " + SiraliKitaplar.Count);
            Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void BasimYillarinaGoreSirala()
        {
            Console.Clear();
           Console.WriteLine("1990 ile 2020 Arasında Basılan Kitapların Fiyatlarına Göre Sıralanmış Listesi");
            Console.WriteLine($"{"Kitap Adı",-30} {"Yazarı",-30}  {"Yayın Evi",-30}   {"Kategori",-20}  {"Sayfa Sayısı",5}\t{"Basım Yılı",5}     {"Fiyatı",8} ");
            List<Kitap> SiraliKitaplar = Kitaplar.Where(k => k.BasimYili >= 1990 && k.BasimYili <= 2020).OrderBy(k => k.Fiyat).ToList();
            foreach (Kitap ktp in SiraliKitaplar)
            {
                Console.WriteLine($"{ktp.Adi,-35} {ktp.Yazar,-30}  {ktp.YayinEvi,-30}   {ktp.Kategori,-20}  {ktp.SayfaSayisi,5}\t{ktp.BasimYili,5}     {ktp.Fiyat,8:C}");
            }
            Console.WriteLine("\nListedeki Kitap Sayısı...: " + SiraliKitaplar.Count);
            Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }

        private static void KategoriyeGoreSirala()
        {
            Console.Clear();
            Console.WriteLine("Kategoriye Göre Sıralama Seçenekleri\n");
            List<string> Kategoriler = Kitaplar.Select(k => k.Kategori).Distinct().ToList();
            for (int i = 0; i < Kategoriler.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Kategoriler[i]}");
            }
            Console.Write("\nSeçiminiz...:");

            int secim = int.Parse(Console.ReadLine());
            if (secim < 1 || secim > Kategoriler.Count)
            {
                Console.WriteLine("Geçersiz Seçim...Tekrar Deneyin...");
                Thread.Sleep(2000);
                return;
            }
            else
            {
                List<Kitap> SiraliKitaplar = Kitaplar.Where(k => k.Kategori == Kategoriler[secim - 1]).OrderByDescending(k => k.SayfaSayisi).ToList();
                Console.WriteLine();
                foreach (Kitap ktp in SiraliKitaplar)
                {
                    Console.WriteLine($"{ktp.Adi,-35} {ktp.Yazar,-30}  {ktp.YayinEvi,-30}   {ktp.Kategori,-20}  {ktp.SayfaSayisi,5}\t{ktp.BasimYili,5}     {ktp.Fiyat,8:C}");
                }
                Console.WriteLine("\nListedeki Kitap Sayısı...: " + SiraliKitaplar.Count);
                Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın....");
                Console.ReadKey();
            }
        }

        private static void YazarAdinaGoreSirala()
        {
            Console.Clear();
            Console.WriteLine("Yazar Adlarına Göre Sıralanmış Kitaplar Listesi");
            Console.WriteLine($"{"Kitap Adı",-30} {"Yazarı",-30}  {"Yayın Evi",-30}   {"Kategori",-20}  {"Sayfa Sayısı",5}\t{"Basım Yılı",5}     {"Fiyatı",8} ");
            List<Kitap> SiraliKitaplar = Kitaplar.OrderBy(k => k.Yazar).ToList();
            foreach (Kitap ktp in SiraliKitaplar)
            {
                Console.WriteLine($"{ktp.Adi,-35} {ktp.Yazar,-30}  {ktp.YayinEvi,-30}   {ktp.Kategori,-20}  {ktp.SayfaSayisi,5}\t{ktp.BasimYili,5}     {ktp.Fiyat,8:C}");
            }
            Console.WriteLine("\nListedeki Kitap Sayısı...: " + SiraliKitaplar.Count);
            Console.WriteLine("\nDevam Etmek İçin Bir Tuşa Basın....");
            Console.ReadKey();
        }
    }
}
